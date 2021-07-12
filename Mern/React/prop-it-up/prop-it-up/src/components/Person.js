import styles from "./Person.module.css";

const Person = (props) => {
return <div className = {styles.person}>
<h3>{props.lastname}, {props.firstname}</h3>
<p>Age: {props.age}</p>
<p>Hair Color: {props.haircolor}</p>
</div>

}
export default Person;