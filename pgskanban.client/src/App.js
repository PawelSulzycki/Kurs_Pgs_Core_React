import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import {BrowserRouter, Route} from 'react-router-dom';

import Board from './components/Board'
import NewBoard from './components/NewBoard';

class App extends Component {
  render() {
    return (
      <div>
        <BrowserRouter>
        <div>
          <Route path='/new' component={NewBoard}/>
          <Route exact path='/' component={Board}/>
        </div>
        </BrowserRouter>
      </div>
    );
  }
}

export default App;
