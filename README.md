<div align="center">

# 🏥 PERSONALIZED HEALTHCARE TRACKING SYSTEM

**Hệ thống Theo dõi & Quản lý Chăm sóc Sức khỏe Cá nhân Hóa**

[![Platform](https://img.shields.io/badge/Platform-Desktop-blue.svg)]
[![Architecture](https://img.shields.io/badge/Architecture-Multi--Role-success.svg)]
[![Database](https://img.shields.io/badge/Database-Supabase-green.svg)]
[![Status](https://img.shields.io/badge/Status-Design%20%26%20Development-yellow.svg)]

<p align="center">
  <a href="#-giới-thiệu-about">Giới thiệu</a> •
  <a href="#-mục-tiêu--phạm-vi-project-goals">Mục tiêu</a> •
  <a href="#-phân-hệ-chức-năng-core-modules">Phân hệ</a> •
  <a href="#-quy-trình-nghiệp-vụ-business-workflow">Quy trình</a> •
  <a href="#-định-hướng-kiến-trúc-system-architecture">Kiến trúc</a>
</p>

</div>

---

## 📖 Giới thiệu (About)

**Personalized Healthcare Tracking System** là một hệ thống phần mềm được thiết kế nhằm **số hóa toàn bộ quy trình khám chữa bệnh**, từ tiếp nhận bệnh nhân, khám lâm sàng – cận lâm sàng, kê đơn thuốc, cấp phát thuốc cho đến theo dõi tái khám và sử dụng thuốc sau điều trị.

Hệ thống tập trung vào **cá nhân hóa việc chăm sóc sức khỏe**, giúp:
- Bệnh nhân **không quên lịch khám, không quên uống thuốc**
- Bác sĩ **giảm giấy tờ, tăng hiệu quả ra quyết định lâm sàng**
- Dược sĩ **đảm bảo an toàn dùng thuốc và quản lý kho chính xác**

Dự án được xây dựng theo mô hình **đa phân hệ – đa vai trò**, phù hợp triển khai tại **bệnh viện, phòng khám, hoặc hệ thống y tế quy mô vừa và lớn**.

---

## 🎯 Mục tiêu & Phạm vi Project (Project Goals)

### 🎯 Mục tiêu chính
- Số hóa bệnh án và quy trình khám chữa bệnh
- Giảm sai sót trong kê đơn và cấp phát thuốc
- Hỗ trợ bệnh nhân chủ động theo dõi sức khỏe dài hạn

### 📌 Phạm vi
- Quản lý khám bệnh ngoại trú
- Kê đơn thuốc điện tử (E-Prescription)
- Theo dõi tái khám và sử dụng thuốc
- Quản lý kho dược

---

## 🧩 Phân hệ Chức năng (Core Modules)

### 👤 1. Phân hệ dành cho **Bệnh nhân**
**Mục tiêu:** Trao quyền chủ động quản lý sức khỏe cá nhân.

#### Tính năng chính:
- 📅 **Đặt lịch hẹn thông minh (Smart Booking)**
  - Xem danh sách bác sĩ & chuyên khoa
  - Xem lịch trống theo thời gian thực
  - Đặt lịch và nhận xác nhận ngay

- ⏰ **Nhắc nhở lịch hẹn (Appointment Reminders)**
  - Nhắc trước 1 ngày và 2 giờ
  - Theo dõi trạng thái cuộc hẹn (đã khám / quá hạn)

- 💊 **Trợ lý uống thuốc ảo – Tính năng cốt lõi**
  - Đơn thuốc điện tử tự động hiển thị
  - Phân tích tần suất & hướng dẫn dùng thuốc
  - Tạo lịch nhắc uống thuốc chi tiết theo ngày & giờ

- 📂 **Hồ sơ sức khỏe điện tử cá nhân (PHR)**
  - Lịch sử khám bệnh
  - Chẩn đoán, chỉ số sinh hiệu
  - Tiền sử bệnh & dị ứng

---

### 🩺 2. Phân hệ dành cho **Bác sĩ**
**Mục tiêu:** Tối ưu quy trình khám, hỗ trợ quyết định lâm sàng.

#### Tính năng chính:
- 📋 **Dashboard & hàng đợi bệnh nhân**
  - Danh sách bệnh nhân theo ngày
  - Trạng thái: đã check-in / đang chờ

- 🧠 **Bệnh án điện tử (EMR)**
  - Nhập triệu chứng, tiền sử, sinh hiệu
  - Xem nhanh lịch sử bệnh & dị ứng

- 💊 **Kê đơn thuốc thông minh (Smart E-Prescribing)**
  - Tìm kiếm thuốc từ kho
  - ⚠️ **Cảnh báo tương tác thuốc**
    - Kiểm tra tương tác nghiêm trọng (`severe`, `contraindicated`)
    - Cảnh báo ngay trong lúc kê đơn

---

### 💊 3. Phân hệ dành cho **Dược sĩ**
**Mục tiêu:** Đảm bảo an toàn dùng thuốc & quản lý kho hiệu quả.

#### Tính năng chính:
- 📥 **Hàng đợi đơn thuốc thời gian thực**
  - Nhận đơn ngay khi bác sĩ kê xong

- 🔍 **Kiểm tra lâm sàng (Clinical Verification)**
  - Kiểm tra liều lượng theo tuổi, cân nặng
  - Duyệt đơn và ghi nhận dược sĩ phụ trách

- 📦 **Cấp phát & trừ kho tự động**
  - Trừ tồn kho ngay khi cấp thuốc
  - Theo dõi lịch sử cấp phát

- 🚨 **Cảnh báo tồn kho thấp**
  - Phát hiện thuốc sắp hết
  - Hỗ trợ lập kế hoạch nhập kho

---

## 🏗 Định hướng Kiến trúc (System Architecture)

- **Multi-Role Architecture**
  - Patient App
  - Doctor Portal
  - Pharmacist Portal

- **Layered Design**
  - Presentation Layer
  - Business Logic Layer
  - Data Access Layer
  - Database Layer

- **Khả năng mở rộng**
  - Tích hợp xét nghiệm, chẩn đoán hình ảnh
  - AI hỗ trợ chẩn đoán trong tương lai

---

## 📌 Kết luận

**Personalized Healthcare Tracking System** hướng đến một hệ sinh thái y tế hiện đại, nơi mọi chủ thể (bệnh nhân – bác sĩ – dược sĩ) đều được hỗ trợ bằng công nghệ, giúp **nâng cao chất lượng điều trị, giảm sai sót và tối ưu trải nghiệm y tế**.

---

## 👥 Nhóm Tác giả (Authors) 

| STT | Sinh viên thực hiện | MSSV |
| :--: | :--- | :--- |
| **1** | **Nguyễn Đại Hưng** | 24520601 |
| **2** | **Lê Huỳnh Anh Tuấn** | 24521928 | 

---

© 2025 **Personalized Healthcare Tracking System**  
*Healthcare Software Project*
