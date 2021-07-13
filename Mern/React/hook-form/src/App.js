import React, {useState} from "react";
import './App.css';
import Register from "./components/Register";
import Results from "./components/Results";


function App() {
  const [ state, setState] = useState({
    firstName: "",
    lastName: "",
    email: "",
    Password: "",
    confirmPassword: ""
  });

  return (
    <div className="App">
    <Register inputs={state} setInputs={setState} /><br></br>
    <Results data={state} />
    </div>
  );
}

export default App;