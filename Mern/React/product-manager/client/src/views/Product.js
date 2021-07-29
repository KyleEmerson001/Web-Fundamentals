import { useEffect, useState } from "react";
import axios from "axios";
import { navigate } from "@reach/router";

const Product = (props) => {
  const [product, setProduct] = useState(null);

  useEffect(() => {
    axios
      .get("http://localhost:5000/api/products/" + props.id)
      .then((res) => {
        console.log(res);
        setProduct(res.data);
      })
      .catch((err) => {
        console.log(err);
      });
  }, [props.id]);

  const handleDelete = (id) => {
    axios
      .delete("http://localhost:5000/api/products/" + id)
      .then((res) => {
        console.log(res);
        navigate("/products");
      })
      .catch((err) => {
        console.log(err);
      });
  };

  if (product === null) {
    return "Loading...";
  }

  return (
    <div>
      <h4>{product.title}</h4>
      <p>{product.price}</p>
      <p>{product.description}</p>


      <div>
        <button
          onClick={(e) => {
            handleDelete(product._id);
          }}
        >
          Delete
        </button>
      </div>
    </div>
  );
};

export default Product;