import React, {useState} from "react"

const FetchPokemon = () => {
const [pokemon, setPokemon] = useState([]);

    const getPokemon=() => {
        fetch("https://pokeapi.co/api/v2/pokemon/?limit=807")
        .then(response => {
            console.log(response);
            return response.json();
        }) .then(response => {
            console.log(response);
            setPokemon(response.results);
        }).catch(err => {
            console.log(err)
        });
    }
    return(
        <div className="row">
            <div className="text-center">
                <button onClick={ getPokemon } type="button" className="btn btn-warning btn-lg">Fetch Pokemon</button>
                <div className="row">
            { 
            pokemon.map((val, i)=> 

                    <li key={ i }>{ val.name }</li>

                )}
                </div>
            </div>
        </div>
    )
}

export default FetchPokemon