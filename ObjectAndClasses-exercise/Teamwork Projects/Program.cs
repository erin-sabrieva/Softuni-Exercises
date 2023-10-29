using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var teams = new List<Team>();
            for (int i = 0; i < count; i++)
            {
                string[] currTeamInfo = Console.ReadLine().Split("-");
                string creator = currTeamInfo[0];
                string name = currTeamInfo[1];
                if (teams.Any(team=> team.Name== name))
                {
                    Console.WriteLine($"Team {name} was already created!");
                }
                else if (teams.Any(team=> team.Creator== creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Creator = creator;
                    team.Name = name;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {name} has been created by {creator}!");
                }
                
            }
            var line = Console.ReadLine();
            while (line!= "end of assignment")
            {
                
                var memberName = line.Split(new string[] {"->" }, StringSplitOptions.None)[0];
                var teamToJoin = line.Split(new string[] { "->" }, StringSplitOptions.None)[1];
                if (teams.Any(member => member.Members.Contains(memberName) || teams.Any(creator => creator.Creator == memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else if (teams.All (team => team.Name != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    var currTeam = teams.Find(team => team.Name == teamToJoin);
                    currTeam.Members.Add(memberName);
                }
                line = Console.ReadLine();

            }
            var completedTeam = teams.Where(x => x.Members.Count>0);
            var disbanedeTeam = teams.Where(x => x.Members.Count == 0);
            foreach (var team in completedTeam.OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }

            }
            Console.WriteLine("Teams to disband:");
            if (disbanedeTeam !=null)
            {
                foreach (var team in disbanedeTeam.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{team.Name}");
                }
            }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
