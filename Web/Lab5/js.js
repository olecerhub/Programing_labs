function AddLisner () {
  var bookmark = {id: prompt("Id:"), name: prompt("Name:"), description: prompt("Description:")};
  var foo = {link: prompt("Link:")};
  bookmark.__proto__ = foo;
  var str = "<li id='" + bookmark.id + "'><a href='" + bookmark.link + "'><b>" + bookmark.name + ": </b>" + bookmark.description + "</a></li>";
  $("#ForBookmarks").html(str);
}

function DeleteLisner () {
  var length = $("#ForBookmarks li").length;
  $("#ForBookmarks li:nth-child(" + length + ")").html("");
}
