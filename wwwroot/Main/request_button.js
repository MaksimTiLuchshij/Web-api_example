class RequestButton extends React.Component {
    constructor(props) {
        super(props);
        this.state = {completed: false, guid: ''};
    }

    render() {
        if (this.state.completed) {
            return this.state.guid;
        }

        return React.createElement('button',
            {
                onClick: () =>
                    fetch('/GetSomeGuid')
                        .then((response) => response.json())
                        .then((data) => this.setState({completed: true, guid: data}))
            }, 'Send');
    }
}

ReactDOM.render(React.createElement(RequestButton), document.querySelector('#request_container'));
