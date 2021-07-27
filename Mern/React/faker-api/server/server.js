const express = require("express");
const cors = require("cors");
 
// Environment vars.
const port = 5000;
 var faker = require("faker");

class User{
  constructor(){
    this.user_Id = faker.datatype.number();
    this.firstName = faker.name.firstName();
    this.lastName = faker.name.lastName();
    this.phoneNumber = faker.phone.phoneNumber();
    this.email = faker.internet.exampleEmail();
    this.password = faker.internet.password();
  }
}

class Company{
  constructor(){
    this.company_Id = faker.datatype.number();
    this.companyName = faker.company.companyName();
    this.companyStreet = faker.address.streetAddress();
    this.companyCity = faker.address.city();
    this.companyState = faker.address.state();
    this.companyZipCode = faker.address.zipCode();
    this.companyCountry = faker.address.country();
  }
}

const app = express();
app.use(express.json());
app.use(cors());
 
app.get("/api", (req,res) => {
    res.json({message:"this works"})
})

app.get("/user/new", (req,res) => {
  const userInfo = new User();
  res.json({user: userInfo})
})

app.get("/companies/new", (req,res) => {
  const companyInfo = new Company();
  res.json({company: companyInfo})
})

app.get("/company", (req,res) => {
  const companyInfo = new Company();
  const userInfo = new User();
  res.json({company: companyInfo, user: userInfo})

})
 
app.listen(port, () =>
  console.log(`Listening on port ${port} for REQuests to RESpond to.`)
);
