import React, { useState } from "react";
import styles from "./Person.module.css";

const Person = (props) => {
const[years, setYears] = useState(props.profile.yearCount);


return (
<div className = {styles.Person}>
<h3>{props.profile.lastname}, {props.profile.firstname}</h3>
<p>Age: {years}</p>
<p>Hair Color: {props.profile.haircolor}</p>
<p>
        <button
          className={styles.heart}
          onClick={(e) => {
            setYears(years + 1);
          }}
        >
          Birthday Button for {props.profile.firstname} {props.profile.lastname}
        </button>
      </p>
</div>
);
};
export default Person;