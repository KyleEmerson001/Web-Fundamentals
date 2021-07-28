const express = require("express");
const cors = require("cors");


const port = 5000;
const db_name = "jokes_api";
 
// Immediately execute the import mongoose.config.js function.
require("./config/mongoose.config")(db_name);
 
const app = express();
 
// req.body undefined without this!
app.use(express.json());
app.use(cors());
 
require("./routes/joke.routes")(app);
 
app.listen(port, () =>
  console.log(`Listening on port ${port} for REQuests to RESpond to.`)
);
