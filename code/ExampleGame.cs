using Sandbox;

public partial class Quakematch : Sandbox.Game
{
	public override void ClientJoined( Client client )
	{
		base.ClientJoined( client );

		// Create a pawn and assign it to the client.
		var player = new QMPlayer();
		client.Pawn = player;

		player.Respawn();
	}
}