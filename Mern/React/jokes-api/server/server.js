const express = require("express");
const cors = require("cors");


const port = 5000;
 
// Immediately execute the import mongoose.config.js function.
require("./config/mongoose.config");
 
const app = express();
 
// req.body undefined without this!
app.use(express.json());
app.use(cors());
 
require("./routes/joke.routes")(app);
 
app.listen(port, () =>
  console.log(`Listening on port ${port} for REQuests to RESpond to.`)
);
