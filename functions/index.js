const functions = require('firebase-functions');

// The Firebase Admin SDK to access the Firebase Realtime Database.
const admin = require('firebase-admin');
const express = require('express');
const cors = require('cors');

admin.initializeApp();
const app = express();

app.use(cors({origin: true}));

// Add middleware to authenticate requests
// app.use(myMiddleware);

// build multiple CRUD interfaces:
app.get('/test', (req, res) => res.send({test: 'My Nane'}));
app.post('/test', (req, res) => {
    console.req(res.body);
    if (req.body.hasOwnProperty(data)){
        res.send({data: req.body['data']})
    } else {
        res.send({noData: true})
    }
});

exports.widgets = functions.https.onRequest(app);

