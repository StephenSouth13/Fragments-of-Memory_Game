import PageWrapper from "../components/PageWrapper";
import ModelViewer from "../components/ModelViewer";

export default function Play() {
  return (
    <PageWrapper>
      <section className="py-10 px-6">
        <h2 className="text-3xl font-bold mb-6">🧊 Mô hình 3D thử nghiệm</h2>
        <div className="h-[600px] w-full">
          <ModelViewer />
        </div>
        <p className="mt-4 text-center text-gray-500 dark:text-gray-400">
          * Bạn có thể xoay, phóng to/thu nhỏ mô hình để xem chi tiết!
        </p>
      </section>
    </PageWrapper>
  );
}
// This page allows users to interact with 3D models in a viewer.
// It includes a title, a viewer component, and instructions for interaction.