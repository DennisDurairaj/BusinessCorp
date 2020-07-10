using System;
using Xunit;

namespace BusinessCorp.TeamService.Tests
{
  public class TeamsControllerTest
  {
    TeamsController controller = new TeamsController();
    [Fact]
    public void QueryTeamListReturnsCorrectTeams()
    {
      List<Team> teams = new List<Team>(controller.GetAllTeams());
    }
  }
}
