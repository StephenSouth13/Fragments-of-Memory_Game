import { useState, useEffect } from "react";
import { BrowserRouter as Router, Routes, Route, useLocation } from "react-router-dom";
import { AnimatePresence } from "framer-motion";

import Header from "./components/Header";
import Footer from "./components/Footer";

import Home from "./pages/Home";
import About from "./pages/About";
import Team from "./pages/Team";
import Models from "./pages/Models";
import Donate from "./pages/Donate";
import Contact from "./pages/Contact";
import Play from "./pages/Play";
import FAQ from "./pages/FAQ";
import Feedback from "./pages/Feedback";

// Wrapper để hỗ trợ AnimatePresence khi thay đổi Route
function AppContent({ darkMode, toggleDark }) {
  const location = useLocation();

  return (
    <div className="min-h-screen bg-white text-black dark:bg-black dark:text-white transition-colors duration-300">
      <Header darkMode={darkMode} toggleDark={toggleDark} />
      <main className="p-4">
        <AnimatePresence mode="wait">
          <Routes location={location} key={location.pathname}>
            <Route path="/" element={<Home />} />
            <Route path="/about" element={<About />} />
            <Route path="/team" element={<Team />} />
            <Route path="/models" element={<Models />} />
            <Route path="/donate" element={<Donate />} />
            <Route path="/contact" element={<Contact />} />
            <Route path="/play" element={<Play />} />
            <Route path="/faq" element={<FAQ />} />
            <Route path="/feedback" element={<Feedback />} />
          </Routes>
        </AnimatePresence>
      </main>
      <Footer />
    </div>
  );
}

function App() {
  const [darkMode, setDarkMode] = useState(false);

  useEffect(() => {
    document.documentElement.classList.toggle("dark", darkMode);
  }, [darkMode]);

  return (
    <Router>
      <AppContent darkMode={darkMode} toggleDark={() => setDarkMode(!darkMode)} />
    </Router>
  );
}

export default App;
// This is the main entry point of the application.
// It sets up the router and wraps the main content with a header and footer.
// The AppContent component handles the routing and dark mode toggle.
// The useEffect hook applies the dark mode class to the document element based on the state.
// The AnimatePresence component from Framer Motion is used to animate route transitions.
