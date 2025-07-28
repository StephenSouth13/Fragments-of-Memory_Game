/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./index.html",
    "./src/**/*.{js,ts,jsx,tsx}",
  ],
  darkMode: 'class', // Cho phép dùng dark mode qua class
  theme: {
    extend: {
      colors: {
        primary: '#1DA1F2',      // Màu chính
        secondary: '#14171A',    // Màu phụ
      },
      fontFamily: {
        sans: ['Inter', 'sans-serif'], // Font mặc định
      },
    },
  },
  plugins: [],
};
