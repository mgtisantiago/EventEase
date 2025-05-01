let session = {
    isAuthenticated: false,
    user: null
};

function startSession(user) {
    session.isAuthenticated = true;
    session.user = user;
}

function endSession() {
    session.isAuthenticated = false;
    session.user = null;
}

window.sessionTracker = {
    startSession: startSession,
    endSession: endSession
};
