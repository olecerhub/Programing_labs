class Bookmarks {
    constructor(id, name, description, link) {
        this.id = id;
        this.name = name;
        this.description = description;
        this.link = link;

        this.str = "<li id='" + this.id + "'><a href='" + this.link + "'><b>" + this.name + ": </b>" + this.description + "</a></li>";
        $("#ForBookmarks").html(this.str);
    }
}

function AddLisner () {
  let bookmark = new Bookmarks (prompt("Id:"),prompt("Name:"),prompt("Description:"),prompt("Link:"));
}

function DeleteLisner () {
  var length = $("#ForBookmarks li").length;
  $("#ForBookmarks li:nth-child(" + length + ")").html("");
}

function ServerJSONChange (id, name, description, link) {
  
}
