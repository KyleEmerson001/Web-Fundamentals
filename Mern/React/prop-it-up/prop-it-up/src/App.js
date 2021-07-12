import './App.css';
import Person from "./components/Person"

function App() {
  const profiles = [
    {
      firstname:"Jane",
      lastname: "Doe",
      yearCount: 45,
      haircolor: "Black",
    },
    {
      firstname:"John",
      lastname: "Smith",
      yearCount: 88,
      haircolor: "Brown",
    }

  ];
  
  return (
    <div className="container">
    {profiles.map((profile, i) => {
        return <Person key={i} profile={profile} />;
      })}
    </div>
  );
}

export default App;
