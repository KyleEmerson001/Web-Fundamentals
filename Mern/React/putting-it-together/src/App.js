import './App.css';
import Person from "./components/Person"

function App() {
  return (
    <div className="container">
<div><Person firstname="Jane" lastname = "Doe" age = "45" haircolor = "Black" /></div>
<div><Person firstname="John" lastname = "Smith" age = "88" haircolor = "Brown" /></div>
<div><Person firstname="Millard" lastname = "Fillmore" age = "50" haircolor = "Brown" /></div>
<div><Person firstname="Maria" lastname = "Smith" age = "62" haircolor = "Brown" /></div>
    </div>
  );
}

export default App;