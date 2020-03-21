import React from "react";
//import Img_Name from "./img_name";
//import importAll from "./import_images";
//import Rename from "./renamer";
//import { Link } from "react-router-dom";
//<h5 class="card-title">{contact.name}</h5>
//<Link to={Rename(contact.name)}>{contact.name} </Link>
//          <h6 class="card-subtitle mb-2 text-muted">{contact.email}</h6>
//        <p class="card-text">{contact.company.catchPhrase}</p>
const images = require.context("./pics/", true);
const Contacts = ({ contacts }) => {
  console.log(contacts);
  return (
    <div>
      <center>
        <h1>Card List</h1>
      </center>
      {contacts.map(contact => (
        <div class="card" style={{ width: "10rem", margin: "15px" }}>
          <img
            src={images("./" + contact.id + ".jpg")}
            alt={contact.id}
            class="card-img-top"
          ></img>
        </div>
      ))}
    </div>
  );
};

export default Contacts;
