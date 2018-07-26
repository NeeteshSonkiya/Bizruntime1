var input = Rx.Observable.fromEvent(document.querySelector('input'), 'input');

input.map(event => event.target.value)
  .subscribe(value => document.getElementById("p1").innerHTML = (value)); 
var stopStream = Rx.Observable.fromEvent(document.querySelector('button'), 'click');
input.takeUntil(stopStream)
  .map(event => event.target.value)
  .subscribe(value => document.getElementById("p2").innerHTML = (value)); 