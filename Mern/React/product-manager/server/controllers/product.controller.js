const Product = require("../models/product.model");


module.exports = {

  create: function (req, res) {
    console.log("create method executed")

    Product.create(req.body)
    .then((product) => {

      res.json(product);
    })
    .catch((err) => {
      res.status(400).json(err);
    });
  },
 
  getAll(req,res) {
    console.log("getAll method executed");

    Product.find()
    .then((products) => {
      res.json(products);
    })
    .catch((err) => {
      res.status(400).json(err);
    });
  },
  getOne(req,res) {
    console.log("getOne method Executed", "url params", req.params);

    Product.findById(req.params.id)
    .then((product) => {
      res.json(product)
    })
    .catch((err) => {
      res.status(400).json(err);
    });
  },

  delete(req, res) {
    console.log("delete method executed","url params", req.params);

    Product.findByIdAndDelete(req.params.id)
      .then((product) => {
        res.json(product);
      })
      .catch((err) => {
        res.status(400).json(err);
      });
  },

  update(req, res) {
    console.log("update method executed", "url params:", req.params); 

    Product.findByIdAndUpdate(req.params.id, req.body, {
      runValidators: true,
      new: true,
    })
    .then((updatedProduct) => {
      res.json(updatedProduct);
    })
    .catch((err) => {
      res.status(400).json(err);
    });
  },
};