const express = require("express");
const cors = require("cors");

const port = 5000;
const db_name = "product-manager";

require("./config/mongoose.config")(db_name);

const app = express();

app.use(express.json());
app.use(cors());
require("./routes/product.routes")(app);

app.listen(port, () =>
  console.log(`Listening on port ${port} for REQuests to RESpond to.`)
);