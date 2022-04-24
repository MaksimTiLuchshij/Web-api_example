class RequestForm extends React.Component {
    constructor(props) {
        super(props);
        this.state = {value: '', configKey: ''};

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(event) {
        this.setState({configKey: event.target.value});
    }

    handleSubmit(event) {
        fetch(`/GetConfigValue?key=${this.state.configKey}`)
            .then(response => response.json())
            .then(data => this.setState({value: data}));
        event.preventDefault();
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <label>
                    {this.state.value}
                    <input type="text" value={this.state.configKey} onChange={this.handleChange}/>
                </label>
                <input type="submit" value="Send"/>
            </form>
        );
    }
}

ReactDOM.render(React.createElement(RequestForm), document.querySelector('#request_form_container'));
