import { Canvas } from "@react-three/fiber";
import { OrbitControls, Environment } from "@react-three/drei";
import { Suspense } from "react";
import { useGLTF } from "@react-three/drei";

function Model({ path }) {
  const { scene } = useGLTF(path);
  return <primitive object={scene} scale={1.5} />;
}

export default function ModelViewer({ modelPath }) {
  return (
    <div className="w-full h-[500px] rounded-md overflow-hidden shadow-lg bg-gray-100 dark:bg-gray-800">
      <Canvas camera={{ position: [0, 1, 5], fov: 50 }}>
        <ambientLight intensity={1} />
        <Suspense fallback={null}>
          <Model path={modelPath} />
          <Environment preset="sunset" />
        </Suspense>
        <OrbitControls />
      </Canvas>
    </div>
  );
}
