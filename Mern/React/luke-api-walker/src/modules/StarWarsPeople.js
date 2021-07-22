import React, { useEffect, useState } from 'react';
import axios from 'axios';

const StarWarsPeople = (props) => {
  const [people, setPeople] = useState(null);

  useEffect(() => {
    axios
    .get("https://swapi.dev/api/people/" + props.id)
    .then((res) => {
      setPeople(res.data);
      console.log(setPeople)
      console.log(res.data)
    })
    .catch((err) => {
      console.log('ERROR')
    });
  },[props.id]);

  if (people === null) {
    return "Loading"
  }

  return (
    <div>
      <h1>Name: {people.name}</h1>
      <h3>Height: {people.height}</h3>
      <h3>Hair Color: {people.hair_color}</h3>
      <h3>Skin Color: {people.skin_color} </h3>
    </div> 
  );
}

export default StarWarsPeople;