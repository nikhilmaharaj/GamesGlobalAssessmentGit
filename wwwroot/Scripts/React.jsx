const s = {
    color: "black",
    paddingTop: "25px",
    alignItems: "center",
    justifyContent: "center",
    fontFamily: "Arial"
};

const header1 =
    (<h1 style={s}>TV Show List</h1>)

//const header2 =
//    (<h1 style={s}>Edit TV Show</h1>)

//const header3 =
//    (<h1 style={s}>Remove TV Show</h1>)

ReactDOM.render(
    header1, document.querySelector('#header1')
)
//ReactDOM.render(
//    header2, document.querySelector('#header2')
//),
//ReactDOM.render(
//    header3, document.querySelector('#header3')
//);

//class Header1 extends React.Component {
//    render() {
//        return (<h1 style={s}>TV Show List</h1>);
//    }
//}

//class Header2 extends React.Component {
//    render() {
//        return (<h1 style={s}>Edit TV Show</h1>);
//    }
//}
