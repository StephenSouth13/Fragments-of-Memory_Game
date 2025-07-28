import { Link } from "react-router-dom";

export default function Header() {
  return (
    <header className="bg-gray-900 text-white p-4 sticky top-0 z-50">
      <nav className="flex justify-between items-center">
        <h1 className="text-xl font-bold">The Next Generation</h1>
        <div className="space-x-4">
          <Link to="/">Trang chủ</Link>
          <Link to="/about">Giới thiệu</Link>
          <Link to="/team">Nhóm</Link>
          <Link to="/models">3D</Link>
          <Link to="/play">Chơi thử</Link>
          <Link to="/contact">Liên hệ</Link>
        </div>
      </nav>
    </header>
  );
}


