using System;
using System.Collections.Generic;
using System.Linq;
using Marathon.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Marathon
{
    [TestClass]
    public class TestDataGenerator
    {
        private int _firstHomePlayerId;
        private int _secondHomePlayerId;
        private int _firstGuestPlayerId;
        private int _secondGuestPlayerId;

        [TestMethod]
        public void GenerateData()
        {
            var startingTime = new DateTime(2018, 1, 12, 19, 0, 0);

            using (var context = new MarathonContext())
            {
                var homePlayers = context.Players.Where(x => x.Team.IsHome).ToList();
                var guestPlayers = context.Players.Where(x => !x.Team.IsHome).ToList();

                var totalPoints = 3000;
                var random = new Random(DateTime.Now.Second);
                var currentTime = startingTime;
                for (var i = 0; i < totalPoints; i++)
                {
                    currentTime = currentTime.AddSeconds(random.Next() % 40);

                    if (i % 20 == 0)
                    {
                        GenerateRandomPlayers(homePlayers, guestPlayers);
                        context.SaveChanges();
                    }

                    var teamId = random.Next() % 3;
                    AddPoint(teamId <= 0 ? 1 : teamId, _firstHomePlayerId, _secondHomePlayerId, _firstGuestPlayerId, _secondGuestPlayerId, currentTime, context);
                }

                context.SaveChanges();
            }
        }

        private void GenerateRandomPlayers(List<Player> homePlayers, List<Player> guestPlayers)
        {
            var random = new Random(DateTime.Now.Millisecond);
            var randomNumber = random.Next() % homePlayers.Count;

            _firstHomePlayerId = homePlayers[randomNumber < 0 ? 1 : randomNumber].Id;
            var restHomePlayers = homePlayers.Where(x => x.Id != _firstHomePlayerId).ToList();
            randomNumber = random.Next() % restHomePlayers.Count;
            _secondHomePlayerId = restHomePlayers[randomNumber < 0 ? 1 : randomNumber].Id;

            randomNumber = random.Next() % guestPlayers.Count;
            _firstGuestPlayerId = guestPlayers[randomNumber < 0 ? 1 : randomNumber].Id;
            var restGuestPlayers = guestPlayers.Where(x => x.Id != _firstGuestPlayerId).ToList();
            randomNumber = random.Next() % restGuestPlayers.Count;
            _secondGuestPlayerId = restGuestPlayers[randomNumber < 0 ? 1 : randomNumber].Id;
        }

        private void AddPoint(int teamId, int homePlayerOneId, int homePlayerTwoId, int guestPlayerOneId, int guestPlayerTwoId, DateTime currentTime, MarathonContext context)
        {
            var lastPoint = context.Points.OrderByDescending(x => x.Created).FirstOrDefault();
            var matchId = 1;

            if (lastPoint != null)
            {
                var savedPlayers = new List<int> { lastPoint.HomePlayerOneId, lastPoint.HomePlayerTwoId, lastPoint.GuestPlayerOneId, lastPoint.GuestPlayerTwoId };
                var actualPlayers = new List<int> { homePlayerOneId, homePlayerTwoId, guestPlayerOneId, guestPlayerTwoId };

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
                Created = currentTime,
                GainTeamId = teamId,
                HomePlayerOneId = homePlayerOneId,
                HomePlayerTwoId = homePlayerTwoId,
                GuestPlayerOneId = guestPlayerOneId,
                GuestPlayerTwoId = guestPlayerTwoId,
                MatchId = matchId
            });
        }
    }
}
