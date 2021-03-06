/*
 * PlayerSave.cs
 * 
 * This should get a players saved game information and get it all set up in the game
 * 
 */
using UnityEngine;

public class PlayerSave : MonoBehaviour {
	GameObject player;
	Trainer trainer;
	Vector3 playerPosition;

	void Start() {
		player = GameObject.Find ("Player");
		trainer = player.GetComponent<Trainer> ();
		player.transform.position = PlayerPosition ();
		PopulatePokemonParty ();
		PopulateItems ();
	}

	//Get player position from DB
	Vector3 PlayerPosition() {
		return new Vector3(-462.6291f,50.29899f,5.202448f);
	}

	//Get player party from DB and set it up
	void PopulatePokemonParty() {
		//kanto starters, why not
		trainer.party.AddPokemon(new Pokemon(1, true));
		trainer.party.AddPokemon(new Pokemon(4, true));
		trainer.party.AddPokemon(new Pokemon(7, true));
		Pokedex.states [1] = Pokedex.State.Captured;
		Pokedex.states [4] = Pokedex.State.Captured;
		Pokedex.states [7] = Pokedex.State.Captured;
	}

	//Get players items from DB and add them
	void PopulateItems() {
		trainer.inventory.Add(1, 5); //New inventory code references shared item data. (id, quantity)
		trainer.inventory.Add(4, 2);
	}
}