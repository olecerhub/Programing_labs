// WEB Lab 1

// vars
var name = "Andrew Freziuk";
var a,b,c,d,result;

//Task #1
alert("Task #1");
alert(name);

// Task #2
alert("Task #2");

a = 11;
b = 11;
d = 7;

c = a-b;
result = c+d;

alert(result);

//Task #3
alert("Task #3");

var variant = prompt("Write down your variant");
var integer = parseInt(variant, 10);
variant = integer;

if (variant >=7)
  alert("It's right");
else
  alert("It's not right");

if (variant%2==0) {
  variant+=7;
  alert(variant);
  variant-=7;
}
else {
  variant-=3;
  alert(variant);
  variant+=3;
}

//Task #4
alert("Task #4");

for (var i = 1; i<variant+10; i++)
  alert(i*i);

//Task #5
alert("Task #5");

var ToPrint = true;

for (var i = 2; i<variant+10; i++) {
  for (var z = 2; z < i; z++)
    if (i%z == 0)
      ToPrint = false;
  if (ToPrint == true)
    alert(i);
  ToPrint = true;
}
