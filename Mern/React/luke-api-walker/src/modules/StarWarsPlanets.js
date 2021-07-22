import React, { useEffect, useState } from 'react';
import axios from 'axios';

const StarWarsPlanet = (props) => {
  const [planet, setPlanet] = useState(null);

  useEffect(() => {
    axios
    .get("https://swapi.dev/api/planets/" + props.id)
    .then((res) => {
      setPlanet(res.data);
      console.log(setPlanet)
      console.log(res.data)
    })
    .catch((err) => {
      console.log('ERROR')
    });
  },[props.id]);

  if (planet === null) {
    return <img src="https://memegenerator.net/img/instances/23395689/these-arent-the-droids-youre-looking-for.jpg"></img>
  }
let TF = ""
if (planet.surface_water >0){
  TF = "true"
}
if (planet.surface_water < 1){
  TF = "false"
}
  return (
    <div>
      <h1>{planet.name}</h1>
      <h3>Climate: {planet.climate}</h3>
      <h3>Terrain: {planet.terrain}</h3>
      <h3>Surface Water: {TF}</h3>
      <h3>Population: {planet.population}</h3>
    </div>
  );
}

export default StarWarsPlanet;