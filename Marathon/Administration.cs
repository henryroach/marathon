using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Marathon.Entities;

namespace Marathon
{
    public partial class AdministrationForm : Form
    {
        private ResultsForm _resultsForm;
        private DateTime _marathonStart;
        private int _homeTeamId;
        private int _guestTeamId;

        public AdministrationForm()
        {
            InitializeComponent();
            InitialzeFromDatabase();
            actualTimeTimer.Start();
        }

        private void InitialzeFromDatabase()
        {
            LoadPlayers();

            using (var context = new MarathonContext())
            {
                var settings = context.Settings.SingleOrDefault();

                if (settings == null)
                {
                    context.Settings.Add(new Settings());
                    context.SaveChanges();
                }
                else
                {
                    if (settings.MarathonStart.HasValue)
                    {
                        _marathonStart = settings.MarathonStart.Value;
                        StartTimeTextBox.Text = $"{settings.MarathonStart.Value.ToShortDateString()} {settings.MarathonStart.Value.ToLongTimeString()}";
                        marathonTimer.Start();
                    }
                }

                _homeTeamId = context.Teams.Where(x => x.IsHome).Select(x => x.Id).Single();
                _guestTeamId = context.Teams.Where(x => !x.IsHome).Select(x => x.Id).Single();

                if (settings == null)
                {
                    settings = context.Settings.Single();
                }

                if (settings.ActualHomePlayerOne.HasValue)
                {
                    HomePlayerOneComboBox.SelectedValue = settings.ActualHomePlayerOne.Value;
                }

                if (settings.ActualHomePlayerTwo.HasValue)
                {
                    HomePlayerTwoComboBox.SelectedValue = settings.ActualHomePlayerTwo.Value;
                }

                if (settings.ActualGuestPlayerOne.HasValue)
                {
                    GuestPlayerOneComboBox.SelectedValue = settings.ActualGuestPlayerOne.Value;
                }

                if (settings.ActualGuestPlayerTwo.HasValue)
                {
                    GuestPlayerTwoComboBox.SelectedValue = settings.ActualGuestPlayerTwo.Value;
                }
            }

            RefreshPoints();
        }

        private void RefreshPoints()
        {
            using (var context = new MarathonContext())
            {
                HomePointsLabel.Text = context.Points.Count(x => x.GainTeamId == _homeTeamId).ToString("D5");
                GuestPointsLabel.Text = context.Points.Count(x => x.GainTeamId == _guestTeamId).ToString("D5");
            }
        }

        private void LoadPlayers()
        {
            using (var context = new MarathonContext())
            {
                var homePlayers = context.Teams.Where(x => x.IsHome).SelectMany(x => x.Players).ToList();
                var guestPlayers = context.Teams.Where(x => !x.IsHome).SelectMany(x => x.Players).ToList();

                HomePlayerBindingSource.DataSource = homePlayers;
                HomePlayerOneBindingSource.DataSource = homePlayers;
                HomePlayerTwoBindingSource.DataSource = homePlayers;

                GuestPlayerBindingSource.DataSource = guestPlayers;
                GuestPlayerOneBindingSource.DataSource = guestPlayers;
                GuestPlayerTwoBindingSource.DataSource = guestPlayers;
            }
        }

        private void RefreshResultsForm()
        {
            if (CanUseResultsForm())
            {
                using (var context = new MarathonContext())
                {
                    var teams = context.Teams.ToList();
                    var homeTeamName = teams.Where(x => x.IsHome).Select(x => x.Name).Single();
                    var guestTeamName = teams.Where(x => !x.IsHome).Select(x => x.Name).Single();

                    if (_resultsForm.LeftSideTeamId == _homeTeamId)
                    {
                        _resultsForm.LeftTeamLabel.Text = homeTeamName;
                        _resultsForm.RightTeamLabel.Text = guestTeamName;

                        _resultsForm.LeftPlayerOneLabel.Text = HomePlayerOneComboBox.Text;
                        _resultsForm.LeftPlayerTwoLabel.Text = HomePlayerTwoComboBox.Text;

                        _resultsForm.RightPlayerOneLabel.Text = GuestPlayerOneComboBox.Text;
                        _resultsForm.RightPlayerTwoLabel.Text = GuestPlayerTwoComboBox.Text;
                    }
                    else
                    {
                        _resultsForm.LeftTeamLabel.Text = guestTeamName;
                        _resultsForm.RightTeamLabel.Text = homeTeamName;

                        _resultsForm.LeftPlayerOneLabel.Text = GuestPlayerOneComboBox.Text;
                        _resultsForm.LeftPlayerTwoLabel.Text = GuestPlayerTwoComboBox.Text;

                        _resultsForm.RightPlayerOneLabel.Text = HomePlayerOneComboBox.Text;
                        _resultsForm.RightPlayerTwoLabel.Text = HomePlayerTwoComboBox.Text;
                    }
                }

                RefreshResultsFormScore();
            }
        }

        private void ShowResultsMenuItem_Click(object sender, EventArgs e)
        {
            if (_resultsForm == null || _resultsForm.IsDisposed)
            {
                _resultsForm = new ResultsForm();
                _resultsForm.LeftSideTeamId = _homeTeamId;
                RefreshResultsForm();
                _resultsForm.Show();
            }
        }

        private void HomeAddPointButton_Click(object sender, EventArgs e)
        {
            AddPoint(_homeTeamId);
            RefreshResultsFormScore();
        }

        private void GuestAddPointButton_Click(object sender, EventArgs e)
        {
            AddPoint(_guestTeamId);
            RefreshResultsFormScore();
        }

        private void GuestRemovePointButton_Click(object sender, EventArgs e)
        {
            DeleteLastPoint(_guestTeamId);
            RefreshResultsFormScore();
        }

        private void HomeRemovePointButton_Click(object sender, EventArgs e)
        {
            DeleteLastPoint(_homeTeamId);
            RefreshResultsFormScore();
        }

        private void RefreshResultsFormScore()
        {
            if (CanUseResultsForm())
            {
                if (_resultsForm.LeftSideTeamId == _homeTeamId)
                {
                    _resultsForm.ActualScoreLabel.Text = Convert.ToInt32(HomePointsLabel.Text).ToString().PadRight(4) + ":" + Convert.ToInt32(GuestPointsLabel.Text).ToString().PadLeft(4);
                }
                else
                {
                    _resultsForm.ActualScoreLabel.Text = Convert.ToInt32(GuestPointsLabel.Text).ToString().PadRight(4) + ":" + Convert.ToInt32(HomePointsLabel.Text).ToString().PadLeft(4);
                }
            }
        }

        private void actualTimeTimer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            ActualTimeTextBox.Text = $"{now.ToShortDateString()} {now.ToLongTimeString()}";

            if (CanUseResultsForm())
            {
                _resultsForm.ActualTimeLabel.Text = $"{now.ToShortDateString()} {now.ToLongTimeString()}";
            }
        }

        private void StartMarathonButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jste si jisti, že chcete odstartovat nový maraton?", "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new MarathonContext())
                {
                    var settings = context.Settings.Single();
                    var now = DateTime.Now;
                    settings.MarathonStart = now;

                    context.SaveChanges();

                    _marathonStart = now;
                }

                StartTimeTextBox.Text = $"{_marathonStart.ToShortDateString()} {_marathonStart.ToLongTimeString()}";
                marathonTimer.Start();
            }
        }

        private void marathonTimer_Tick(object sender, EventArgs e)
        {
            var totalTime = TimeSpan.Parse(ConfigurationManager.AppSettings["MarathonCounterTimeout"]);
            var now = DateTime.Now;
            var duration = (now - _marathonStart).Duration();
            var remainingTime = totalTime - duration;

            if (remainingTime.TotalSeconds < 1 || duration > totalTime)
            {
                marathonTimer.Stop();

                PlayedTimeTextBox.Text = totalTime.Add(new TimeSpan(0, 0, -1)).ToString("hh\\:mm\\:ss");
                RemainingTimeTextBox.Text = "00:00:00";

                if (CanUseResultsForm())
                {
                    _resultsForm.RemainingTimeLabel.Text = "00:00:00";
                    _resultsForm.PlayedTimeLabel.Text = totalTime.Add(new TimeSpan(0, 0, -1)).ToString("hh\\:mm\\:ss");
                }
            }
            else
            {
                PlayedTimeTextBox.Text = duration.ToString("hh\\:mm\\:ss");
                RemainingTimeTextBox.Text = remainingTime.ToString("hh\\:mm\\:ss");

                if (CanUseResultsForm())
                {
                    _resultsForm.RemainingTimeLabel.Text = remainingTime.ToString("hh\\:mm\\:ss");
                    _resultsForm.PlayedTimeLabel.Text = duration.ToString("hh\\:mm\\:ss");
                }
            }
        }

        private void HomePlayersGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var playerId = Convert.ToInt32(HomePlayersGridView.Rows[e.RowIndex].Cells["HomePlayerId"].Value);
            var playerName = HomePlayersGridView.Rows[e.RowIndex].Cells["HomePlayerName"].Value.ToString();

            SavePlayer(playerId, playerName, _homeTeamId);
        }

        private void GuestPlayersGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var playerId = Convert.ToInt32(GuestPlayersGridView.Rows[e.RowIndex].Cells["GuestPlayerId"].Value);
            var playerName = GuestPlayersGridView.Rows[e.RowIndex].Cells["GuestPlayerName"].Value.ToString();

            SavePlayer(playerId, playerName, _guestTeamId);
        }

        private void SavePlayer(int id, string name, int teamId)
        {
            if (!string.IsNullOrEmpty(name))
            {
                using (var context = new MarathonContext())
                {
                    if (id == 0)
                    {
                        context.Players.Add(new Player { Name = name, TeamId = teamId });
                    }
                    else
                    {
                        var player = context.Players.Single(x => x.Id == id);
                        player.Name = name;
                    }

                    context.SaveChanges();
                }

                LoadPlayers();
            }
        }

        private void GridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            (sender as DataGridView).Columns[0].Visible = false;
        }

        private void AddPoint(int teamId)
        {
            var homePlayerOneId = Convert.ToInt32(HomePlayerOneComboBox.SelectedValue);
            var homePlayerTwoId = Convert.ToInt32(HomePlayerTwoComboBox.SelectedValue);
            var guestPlayerOneId = Convert.ToInt32(GuestPlayerOneComboBox.SelectedValue);
            var guestPlayerTwoId = Convert.ToInt32(GuestPlayerTwoComboBox.SelectedValue);

            if (homePlayerOneId == 0 || homePlayerTwoId == 0 || guestPlayerOneId == 0 || guestPlayerTwoId == 0)
            {
                return;
            }

            using (var context = new MarathonContext())
            {
                var lastPoint = context.Points.OrderByDescending(x => x.Created).FirstOrDefault();
                var matchId = 1;

                if (lastPoint != null)
                {
                    var savedPlayers = new List<int> { lastPoint.HomePlayerOneId, lastPoint.HomePlayerTwoId, lastPoint.GuestPlayerOneId, lastPoint.GuestPlayerTwoId };
                    var actualPlayers = new List<int> {homePlayerOneId, homePlayerTwoId, guestPlayerOneId, guestPlayerTwoId};

                    if (savedPlayers.Except(actualPlayers).Any())
                    {
                        matchId = lastPoint.MatchId + 1;
                    }
                    else
                    {
                        matchId = lastPoint.MatchId;
                    }
                }

                context.Points.Add(new Point
                {
                    Created = DateTime.Now,
                    GainTeamId = teamId,
                    HomePlayerOneId = homePlayerOneId,
                    HomePlayerTwoId = homePlayerTwoId,
                    GuestPlayerOneId = guestPlayerOneId,
                    GuestPlayerTwoId = guestPlayerTwoId,
                    MatchId = matchId
                });
                context.SaveChanges();
            }

            RefreshPoints();
        }

        private void DeleteLastPoint(int teamId)
        {
            using (var context = new MarathonContext())
            {
                var point = context.Points.Where(x => x.GainTeamId == teamId).OrderByDescending(x => x.Created).FirstOrDefault();

                if (point != null)
                {
                    context.Points.Remove(point);
                    context.SaveChanges();
                }
            }

            RefreshPoints();
        }

        private bool CanUseResultsForm()
        {
            return _resultsForm != null && !_resultsForm.IsDisposed;
        }

        private void AdministrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var context = new MarathonContext())
            {
                var homePlayerOneId = Convert.ToInt32(HomePlayerOneComboBox.SelectedValue);
                var homePlayerTwoId = Convert.ToInt32(HomePlayerTwoComboBox.SelectedValue);
                var guestPlayerOneId = Convert.ToInt32(GuestPlayerOneComboBox.SelectedValue);
                var guestPlayerTwoId = Convert.ToInt32(GuestPlayerTwoComboBox.SelectedValue);

                var settings = context.Settings.Single();
                settings.ActualHomePlayerOne = homePlayerOneId;
                settings.ActualHomePlayerTwo = homePlayerTwoId;
                settings.ActualGuestPlayerOne = guestPlayerOneId;
                settings.ActualGuestPlayerTwo = guestPlayerTwoId;

                context.SaveChanges();
            }
        }

        private void ReverseSideMenuItem_Click(object sender, EventArgs e)
        {
            if (CanUseResultsForm())
            {
                _resultsForm.LeftSideTeamId = _resultsForm.LeftSideTeamId == _homeTeamId ? _guestTeamId : _homeTeamId;

                RefreshResultsForm();

                MessageBox.Show("Strany jsou otočené!", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PlayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshResultsForm();
        }
    }
}
