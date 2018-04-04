import React from 'react';
import axios from 'axios';
import {withRouter} from 'react-router-dom'
import {BASE_URL} from '../constants';

//export mozemu miec kilka exportow w {}
//export default
class NewBoard extends React.Component{
    constructor(){
        super();
        this.state = {
            name: ''
        };
    }

    onChange = (event)=>{
        this.setState({name: event.target.value})
    }

    addBoard =() =>{
        //console.log(this.state.name);
        axios.post(BASE_URL + '/board', {name: this.state.name}).then(()=>{
            //console.log(response);
            this.props.history.push('/');
        })
        .catch((err)=>{
            console.log(err);
        });
    }

    render(){
        return(
            <div>
                <input onChange={this.onChange} value={this.state.name} placeholder="Add new board name" className="from-control" />
                <button onClick={this.addBoard} disabled={!this.state.name} className="btn btn-primary">Add</button>
            </div>
        )
    }
}

export default withRouter(NewBoard);