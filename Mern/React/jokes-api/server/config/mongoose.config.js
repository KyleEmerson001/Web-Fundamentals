const mongoose = require("mongoose");


  mongoose.connect(`mongodb://localhost/jokes_api`, {
      useNewUrlParser: true,
      useUnifiedTopology: true,
    })
    .then(() => 
      console.log(`Successfully connected to jokes_api`))
    .catch(() => 
      console.log(`mongoose connection to jokes_api failed:`, err))

