//name.replace(/ /g, "_");
function Rename(name) {
  return "https://yugioh.fandom.com/wiki/" + name.replace(/ /g, "_");
}

export default Rename;
