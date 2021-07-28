const Joke = require("../models/joke.model");

//read all
module.exports.findAllJokes = (req,res) => {
    Joke.find()
        .then(alljokes => res.json({jokes: alljokes}))
        .catch(err => res.json({message: "no jokes", error: err}))
}
//read one
module.exports.findOneJoke = (req,res) => {
    Joke.find({_id:req.params._id})
        .then(OneJoke => res.json({joke: OneJoke}))
        .catch(err => res.json({message: "no joke", error: err}))
}
//create new
module.exports.createJoke = (req,res) => {
    Joke.create(req.body)
        .then(newJoke => res.json({joke: newJoke}))
        .catch(err => res.status(400).json(err));
}
//update one
module.exports.updateJoke = (req,res) => {
    Joke.updateOne({_id: req.params._id}, {
        $set: {
            setup: req.body.setup,
            punchline: req.body.punchline
        }
    })
    .then(OneJoke => res.json({joke: OneJoke}))
    .catch(err => res.status(400).json(err));
}
//delete one
module.exports.deleteJoke = (req,res) => {
    Joke.remove({_id:req.params._id})
        .then(delJoke => res.json({message: "Joke deleted"}))
        .catch(err => res.json({message: "Joke not deleted", error: err}))
}
//get random
module.exports.findRandom = (req,res) => {
    Joke.find()
        .then(jokes => {
            let rand = Math.floor(Math.random()*jokes.length);
            res.json({joke: jokes[ramd]});
        })
        .catch(err => res.json({message: "joke not detected", error: err}))
}