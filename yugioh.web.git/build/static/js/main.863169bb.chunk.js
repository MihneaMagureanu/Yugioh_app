(this.webpackJsonprestful_api3=this.webpackJsonprestful_api3||[]).push([[0],{10:function(t,e,n){t.exports=n(17)},15:function(t,e,n){},17:function(t,e,n){"use strict";n.r(e);var a=n(0),r=n.n(a),c=n(3),s=n.n(c),o=(n(15),n(1)),u=n.n(o),i=n(4),l=n(5),f=n(6),p=n(8),h=n(7),m=n(9);var d=function(t){return"https://yugioh.fandom.com/wiki/"+t.replace(/ /g,"_")},v=function(t){var e=t.contacts;return console.log(e),r.a.createElement("div",null,r.a.createElement("center",null,r.a.createElement("h1",null,"Card List")),e.map((function(t){return r.a.createElement("div",null,r.a.createElement("div",null,r.a.createElement("a",{href:d(t.name)},t.name)))})))},E=function(t){function e(t){var n;return Object(l.a)(this,e),(n=Object(p.a)(this,Object(h.a)(e).call(this,t))).state={contacts:"[]"},n}return Object(m.a)(e,t),Object(f.a)(e,[{key:"componentDidMount",value:function(){var t=Object(i.a)(u.a.mark((function t(){var e,n;return u.a.wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,fetch("http://localhost:5000/card");case 2:return e=t.sent,t.next=5,e.json();case 5:n=t.sent,this.setState({contacts:JSON.stringify(n)});case 7:case"end":return t.stop()}}),t,this)})));return function(){return t.apply(this,arguments)}}()},{key:"render",value:function(){return r.a.createElement(v,{contacts:JSON.parse(this.state.contacts)})}}]),e}(a.Component);s.a.render(r.a.createElement(E,null),document.getElementById("root"))}},[[10,1,2]]]);
//# sourceMappingURL=main.863169bb.chunk.js.map