import { Route, Switch } from 'react-router-dom';

import TestComponent from './components/TestComponent';
import NotFound from './components/NotFound';
import Home from './components/Home';

import './App.css';

function App() {
    return (
        <Switch>
            <Route path="/test" exact component={TestComponent} />
            <Route path="/" exact component={Home} />
            <Route component={NotFound} />
        </Switch>
    );
}

export default App;
