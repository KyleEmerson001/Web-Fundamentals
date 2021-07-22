import './App.css';
import { Router,navigate } from '@reach/router'; 
import StarwarsPeople from './modules/StarWarsPeople';
import StarwarsPlanet from './modules/StarWarsPlanets';
import { useState } from 'react';

function App() {
  const [type, setType] = useState("people");
  const [id, setID] = useState("");

  const Search = (e) => {
    setType(e.target.value);
    console.log(setType)
  }

  const SearchId = (e) => {
    setID(e.target.value);
  }

  return (
    <div>

        <p>Search for:   
      <select onChange={Search}>
        <option value="people">People</option>
        <option value="planets">Planets</option>
      </select>
      ID: 
      <input type="text" name="id" onInput={SearchId}></input>
      <button onClick={() => navigate(`/${type}/${id}`)}>Search</button>
      </p>
      <Router>
        <StarwarsPeople path="/people/:id" />
        <StarwarsPlanet path="/planets/:id" />
      </Router>
    </div>
  );
}

export default App;