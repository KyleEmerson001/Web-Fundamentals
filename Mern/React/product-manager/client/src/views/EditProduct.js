import React, { useEffect, useState } from "react";
import { navigate } from "@reach/router";
import axios from "axios";

const EditProduct = (props) => {
    const [title, setTitle] = useState("");
    const [description, setDescription] = useState("");
    const [price, setPrice] = useState("");

  const [errors, setErrors] = useState(null);

  useEffect(() => {
    axios
      .get("http://localhost:5000/api/products/" + props.id)
      .then((res) => {
        console.log(res);
        setTitle(res.data.title);
        setDescription(res.data.description);
        setPrice(res.data.Price);
      })
      .catch((err) => {
        console.log(err);
      });
  }, [props.id]);

  const handleEditProductSubmit = (event) => {
    event.preventDefault();

    const editedProduct = {
        title: title,
        description: description,
        price: price,
    };

    axios
      .put(
        `http://localhost:5000/api/products/${props.id}`,
        editedProduct
      )
      .then((res) => {
        console.log(res);
        navigate("/products/" + props.id);
      })
      .catch((err) => {

        setErrors(err.response?.data?.errors);
        console.log(err);
      });
  };

  return (
    <div>
      <h3>Edit Product</h3>

      <form
        onSubmit={(e) => {
          handleEditProductSubmit(e);
        }}
      >
        <div>
          <label>Title</label>
          {errors?.title && (
            <span className="text-danger">{errors?.title?.message}</span>
          )}
          <input
            onChange={(e) => {
              setTitle(e.target.value);
            }}
            type="text"
            value={title}
          />
        </div>

        <div>
          <label>Price</label>
          {errors?.price && (
            <span className="text-danger">{errors?.price?.message}</span>
          )}
          <input
            onChange={(e) => {
              setPrice(e.target.value);
            }}
            type="number"
            value={price}
          />
        </div>

        <div>
          <label>Description</label>
          {errors?.description && (
            <span className="text-danger">{errors?.description?.message}</span>
          )}
          <input
            onChange={(e) => {
              setDescription(e.target.value);
            }}
            type="text"
            value={description}
          />
        </div>

        <button>Save</button>
      </form>
    </div>
  );
};

export default EditProduct;