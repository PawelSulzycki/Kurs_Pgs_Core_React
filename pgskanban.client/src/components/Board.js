import React from 'react';
import List from './List';
import {BASE_URL} from '../constants';
import {withRouter} from 'react-router-dom';
import axios from 'axios';
import './Board.css'

class Board extends React.Component{
    constructor(){
        super();
        this.state ={
            boardName: '',
            boardId: 0,
            boardData: [],
        }
    }

    componentDidMount(){
        axios.get(BASE_URL + '/board').then((response)=>{
                console.log(response);
                this.setState({
                    boardData: response.data.lists, 
                    boardName: response.data.name, 
                    boardId: response.data.id
                })
            })
            .catch(()=>{
                this.props.history.push('/new');;
        });
    }

    renderLists = ()=>{
        return this.state.boardData.map(list=> (
            <List listName={list.name} 
                cards ={[]}/>
            ));
    }
    
    render(){
        return(
            <div>
                <div>
                    {this.state.boardName}
                    {/* <List listName={'my favourite List'}/> */}
                    <button className="btn btn-info">Add new list</button>
                    <input/>
                </div>
                <div className="container-fluid">
                    <div className ="row flex-row flex-nowrap">
                        {this.renderLists()}
                    </div>
                </div>
            </div>
        )
    }
}

export default withRouter(Board);