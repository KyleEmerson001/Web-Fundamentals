import React, { useEffect, useState } from "react";
import axios from "axios";
import { Link } from "@reach/router";

const Products = (props) => {
    const [AllProducts, setAllProducts] = useState([]);
    const [products, setProducts] = useState([]);
  
  
  useEffect(() => {
    axios
      .get("http://localhost:5000/api/products")
      .then((res) => {
        console.log(res);
        setAllProducts(res.data);
        setProducts(res.data);
      })
      .catch((err) => {
        console.log(err);
      });
  }, []);
  
  const handleDelete = (id) => {
    axios
      .delete("http://localhost:5000/api/products/" + id)
      .then((res) => {
        console.log(res);
        const filteredProducts = products.filter((dest) => {
          return dest._id !== id;
        });
  
        setProducts(filteredProducts);
      })
      .catch((err) => {
        console.log(err);
      });
  };
  
return (
<div>
      <header>
        <h2>All Products</h2>
      </header>

      {products.map((prod) => {
        return (
          <div key={prod._id}>
            <h4>
              <Link to={"/products/" + prod._id}>{prod.location}</Link>
            </h4>
            <p>{prod.title}</p>
            <p>{prod.price}</p>
            <p>{prod.description}</p>

            <div>
              <button
                onClick={(e) => {
                  handleDelete(prod._id);
                }}
              >
                Delete
              </button>
              <Link
                to={`/products/${prod._id}/edit`}
              >
                Edit
              </Link>
            </div>
          </div>
        );
      })}
    </div>
    );
};

    export default Products;