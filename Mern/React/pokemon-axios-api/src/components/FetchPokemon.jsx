import React, {useState} from "react"
import axios from 'axios';

const FetchPokemon = () => {
const [pokemon, setPokemon] = useState([]);

const getPokemon = (e) => {
    axios.get('https://pokeapi.co/api/v2/pokemon?offset=0&limit=807')
    .then(response => {
      setPokemon(response.data.results);
    })
    .catch(error => console.log(error))
  };

    
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