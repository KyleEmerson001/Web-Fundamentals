const mongoose = require("mongoose");

const Schema = mongoose.Schema;

const JokeSchema = new mongoose.Schema(
    {
    setup: {
    type: String,
    required: [true, "You need to set up your joke"],
    minlength: [10, "Your joke is too short"],
},
    punchline: {
    type: String,
    required: [true, "What's the joke"],
    minlength: [3, "Your joke is too short"],
}

});

const Joke = mongoose.model("Joke", JokeSchema);

module.exports = Joke;