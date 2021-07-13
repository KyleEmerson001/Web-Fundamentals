import React, {useState} from "react";
const Register = props => {
    const [state, setState] = useState({
        firstName: "",
        lastName: "",
        email: "",
        password: "",
        confirmPassword: "",
    });
    const onChange = e => {
        setState({
            ...state,
            [e.target.name]: e.target.value,
        });
    }
    return(
<form>
    <div>
    <label htmlFor="firstName">First Name</label>
    <input onChange={onChange} type="text" name="firstName" />
    </div>
        <span>{(state.firstName.length < 2) && <p>First Name must be 2 Characters long</p>}</span>
    <div>
    <label htmlFor="lastName">Last Name</label>
    <input onChange={onChange} type="text" name="lastName" />
    </div>
    <span> {(state.lastName.length < 2) && <p>Last Name must be 2 Characters long</p>}</span>
    <div>
    <label htmlFor="email">Email</label>
    <input onChange={onChange} type="text" name="email" />
    </div>
        <span>{(state.email.length < 5) && <p>Email must be 5 Characters long</p>}</span>
    <div>
    <label htmlFor="password">Password</label>
    <input onChange={onChange} type="password" name="password" />
    </div>
        <span>{(state.password.length < 8) && <p>Password must be 8 Characters long</p>}</span>
    <div>
    <label htmlFor="confirmPassword">Confirm Password</label>
    <input onChange={onChange} type="password" name="confirmPassword" />
    </div>
    <span>{(state.confirmPassword !== state.password) && <p>Confirm Password must match Password</p>}</span>
    <button>Register</button>
</form>

    );
};
export default Register;