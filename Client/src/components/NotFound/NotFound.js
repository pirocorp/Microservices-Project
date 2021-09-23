import { Link } from 'react-router-dom';

import './NotFound.css';

const NotFound = () => {
    return (
        <div className="main-wrapper error-page">

            <div className="error-box">
                <h1>404</h1>
                <h3 className="h2 mb-3"><i class="fas fa-exclamation-triangle"></i> Oops! Page not found!</h3>
                <p className="h4 font-weight-normal">The page you requested was not found.</p>
                <Link to="/" className="btn btn-primary">Back to Home</Link>
            </div>

        </div>
    );
}

export default NotFound;