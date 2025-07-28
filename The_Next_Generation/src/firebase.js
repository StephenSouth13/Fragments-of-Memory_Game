// src/firebase.js
import { initializeApp } from "firebase/app";
import { getDatabase } from "firebase/database"; // dùng Realtime Database

const firebaseConfig = {
  apiKey: "AIzaSyBflfbBZnA5aXM-KMf4z5fZJVrQmvbVhVU",
  authDomain: "uniquegame-a11a2.firebaseapp.com",
  databaseURL: "https://uniquegame-a11a2-default-rtdb.asia-southeast1.firebasedatabase.app",
  projectId: "uniquegame-a11a2",
  storageBucket: "uniquegame-a11a2.appspot.com",
  messagingSenderId: "303088081999",
  appId: "1:303088081999:web:cc72b8bb711a155bd8de3a",
  measurementId: "G-JCL4GBY39Q"
};

const app = initializeApp(firebaseConfig);
const db = getDatabase(app);

export { db };
