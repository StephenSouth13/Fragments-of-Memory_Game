import PageWrapper from "../components/PageWrapper";
import ModelViewer from "../components/ModelViewer";

export default function Models() {
  return (
    <PageWrapper>
      <section className="max-w-5xl mx-auto px-4 py-10">
        <h2 className="text-3xl font-bold mb-6">🧊 Mô hình 3D trong Game</h2>
        <p className="mb-8 text-lg text-gray-600 dark:text-gray-300">
          Dưới đây là một số mô hình 3D được sử dụng trong game của chúng tôi. Bạn có thể xoay, phóng to và khám phá chúng!
        </p>

        {/* Ví dụ với model.gltf trong public/assets/model.gltf */}
        <ModelViewer modelPath="/assets/test.fbx" />
      </section>
    </PageWrapper>
  );
}
