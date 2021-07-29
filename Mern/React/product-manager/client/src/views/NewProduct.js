import React, { useState } from "react";
import { navigate } from "@reach/router";
import axios from "axios";

const NewDestination = (props) => {
  const [title, setTitle] = useState("");
  const [description, setDescription] = useState("");
  const [price, setPrice] = useState("");

  const handleNewProductSubmit = (event) => {
    event.preventDefault();

    const newProduct = {
      title: title,
      description: description,
      price: price,
    };
    axios
      .post("http://localhost:5000/api/products", newProduct)
      .then((res) => {
        console.log(res);
        navigate("/products");
      })
      .catch((err) => {
        console.log(err);
      });
  };

  return (
    <div className="App">
      <h1>Product Manager</h1>
      <form
        onSubmit={(e) => {
          handleNewProductSubmit(e);
        }}
      >
        <div>
          <label>Title</label>
          <input
            onChange={(e) => {
              setTitle(e.target.value);
            }}
            type="text"
            className="form-control"
          />
        </div>

        <div>
          <label>Price</label>
          <input
            onChange={(e) => {
              setPrice(e.target.value);
            }}
            type="text"
            className="form-control"
          />
        </div>
        <div>
          <label>Description</label>
          <input
            onChange={(e) => {
              setDescription(e.target.value);
            }}
            type="text"
            className="form-control"
          />
        </div>
        <button>Create</button>
      </form>
    </div>

  );
}

export default NewDestination;
