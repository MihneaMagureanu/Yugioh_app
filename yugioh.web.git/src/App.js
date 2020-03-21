import React, { Component } from "react";
import Contacts from "./components/contacts";

class App extends Component {
  constructor(props) {
    super(props);
    this.state = { contacts: "[]" };
  }
  async componentDidMount() {
    const response = await fetch("http://localhost:3000/card");
    const json = await response.json();
    this.setState({ contacts: JSON.stringify(json) });
  }

  render() {
    return <Contacts contacts={JSON.parse(this.state.contacts)} />;
  }
}

export default App;
