import "./App.css";

import { Link, Redirect, Router } from "@reach/router";
import Products from "./views/AllProducts";
import Product from "./views/Product";
import NewProduct from "./views/NewProduct";
import EditProduct from "./views/EditProduct";


function App() {
  return (
    <div>
      <nav>
        <div>
          <Link to="/products">
            All Products
          </Link>
          <Link to="/products/new">
            New Product
          </Link>
        </div>
      </nav>
      


      <Router>
        <Products path="/products" />
        <Product path="/products/:id" />
        <EditProduct path="/products/:id/edit" />
        <NewProduct path="/products/new" />
        <Redirect from="/" to="/products" noThrow="true" />
      </Router>
    </div>
  );
}

export default App;