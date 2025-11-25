# Personalized Healthcare Tracking System
# Ý tưởng phần mềm
Được xây dựng dựa trên quy trình khám bệnh và kê thuốc:
1. Bệnh nhân tới bệnh viện / phòng khám để bóc số. Tới lượt bệnh nhân, lấy sổ điền thông tin cơ bản, trình bày lí do tới hôm nay khám và nhận được số phòng. Tới phòng, bác sĩ bắt đầu khám lâm sàn cho bệnh nhân.
2. Bác sĩ bắt đầu xem lịch hẹn của mình, kiểm tra thông tin bệnh nhân bao gồm:
	1. Họ tên bệnh nhân
	2. Lí do khám
   Sau khi kiểm tra, bác sĩ bắt đầu khám lâm sàn cơ bản:
	3. Bệnh nhân gặp những Triệu chứng nào ?
	4. Tiền sử bệnh ?
	5. Lịch sử bệnh di truyền ở gia đình ?
	6. Thói quen đời sống ?
	7. Thông tin dị ứng ?
   Sau khi khám lâm sàn, bác sĩ thực hiện khám cận lâm sàn dựa trên thông tin lâm sàn (có thể đi chụp CT, cắt sinh thiết, ...). Cuối cùng, bác sĩ đưa ra chẩn đoán và kê thuốc:
	8. Bệnh gì ?
	9. Kê thuốc gì ?
	10. Liều lượng, tần suất sử dụng ?
   Cuối cùng, bác sĩ lưu thông tin tái khám:
	11. Thông tin bệnh nhân.
	12. Chẩn đoán bệnh.
	13. Ngày tái khám.
	14. Lần khám.
	15. Trạng thái (Cách bao lâu, đã tái khám hoặc không tái khám sau 7 ngày).
	16. Đợt kê thuốc gần nhất, liều lượng, tần suất.
3. Sau khi kê thuốc, bệnh nhân đi qua quầy bán thuốc, dược sĩ sẽ quản lý lại thông tin thuốc sau:
	1. Cảnh báo tác dụng phụ của thuốc, cách lưu trữ thuốc.
	2. Kiểm tra thuốc, liều lượng đã kê phù hợp với bệnh nhân (độ tuổi, cân nặng, và chẩn đoán bệnh).
	3. Sau khi kiểm tra, trừ số thuốc trong kho đã đưa cho bệnh nhân.
4. Đối với bệnh nhân, các thông tin bệnh nhân cần biết như sau:
	1. Về tái khám:
		1. Ngày tái khám.
		2. Lí do khám (Bệnh).
		3. Bác sĩ khám.
		4. Địa điểm khám.
		5. Ghi chú (Bệnh viện không làm vào giờ nào, v.v).
		6. Cách bao lâu ?
		7. Tình trạng cuộc hẹn (Cách bao lâu, đã tái khám hoặc không tái khám sau 7 ngày).
	2. Sử dụng thuốc:
		1. Tên thuốc
		2. Cho bệnh gì.
		3. Tần suất, với mỗi thời điểm uống, cho biết liều lượng.
		4. Trạng thái (Cách bao lâu hoặc đã qua).
# Mục đích phần mềm
#### 1. Phân hệ dành cho Bệnh nhân 
**Mục tiêu:** Trao quyền chủ động quản lý sức khỏe, không bao giờ quên lịch khám và thuốc.
- **Tính năng cốt lõi:**
    - **Đặt lịch hẹn thông minh (Smart Booking):**
        - Xem danh sách bác sĩ và chuyên khoa (`Doctors`).
        - Xem lịch trống của bác sĩ theo thời gian thực (dựa trên `DoctorSchedules` và các `Appointments` đã đặt).
        - Đặt lịch và nhận xác nhận ngay lập tức.
    - **Nhắc nhở Lịch hẹn (Appointment Reminders):**
        - Hệ thống gửi Push Notification nhắc nhở trước 1 ngày và trước 2 giờ khi có lịch hẹn sắp đến (dựa trên trạng thái `scheduled` trong bảng `Appointments`).
    - **Trợ lý Uống thuốc ảo (Virtual Medication Assistant) - _Tính năng đinh_:**
        - Sau khi đi khám, đơn thuốc điện tử (`Prescriptions`) tự động xuất hiện trên app.
        - App sẽ phân tích trường `frequency` (tần suất) và `instruction` (chỉ dẫn - vd: sau ăn) trong bảng `PrescriptionItems` để tạo ra các **Lịch nhắc uống thuốc tự động** trên điện thoại. (Ví dụ: Sáng 8h, Chiều 14h).
    - **Hồ sơ Sức khỏe Điện tử Cá nhân (Personal Health Record - PHR):**
        - Xem lại lịch sử các lần khám trước, chẩn đoán là gì (`MedicalRecords`), các chỉ số sinh hiệu lúc đó ra sao (`ClinicalExaminations`).
#### 2. Phân hệ dành cho Bác sĩ
**Mục tiêu:** Tối ưu hóa quy trình khám chữa bệnh, giảm giấy tờ, hỗ trợ ra quyết định lâm sàng.
- **Tính năng cốt lõi:**
    - **Bảng điều khiển & Hàng đợi bệnh nhân (Dashboard & Patient Queue):**
        - Xem danh sách bệnh nhân đã đặt lịch hôm nay.
        - Biết được bệnh nhân nào đã đến (Checked-in) và đang chờ ở ngoài.
    - **Bệnh án Điện tử (EMR):**
        - Giao diện nhập liệu nhanh các chỉ số sinh hiệu, triệu chứng vào bảng `ClinicalExaminations`.
        - Xem nhanh lịch sử bệnh án và dị ứng của bệnh nhân trước khi bắt đầu khám.
    - **Kê đơn Thuốc Thông minh & An toàn (Smart E-Prescribing):**
        - Tìm kiếm thuốc từ kho dược (`Medications`).
        - **Cảnh báo Tương tác thuốc (Drug Interaction Alert):** Khi bác sĩ chọn 2 loại thuốc trở lên, hệ thống tự động kiểm tra bảng `MedicationInteractions`. Nếu có tương tác mức độ `severe` hoặc `contraindicated`, hệ thống sẽ hiện cảnh báo đỏ ngay lập tức để bác sĩ thay đổi thuốc.
    - **Quản lý Tái khám (Follow-up Tracking):**
        - Đặt ngày tái khám (`next_visit_date`). Hệ thống sẽ tự động nhắc bệnh nhân khi gần đến ngày đó.
#### 3. Phân hệ dành cho Dược sĩ 
**Mục tiêu:** Đảm bảo an toàn dùng thuốc, cấp phát nhanh chóng và quản lý kho chính xác.
- **Tính năng cốt lõi:**
    - **Hàng đợi Đơn thuốc Thời gian thực (Real-time Prescription Queue):**
        - Ngay khi bác sĩ kê đơn xong, đơn thuốc xuất hiện trên màn hình của dược sĩ với trạng thái `pending`. Không cần bệnh nhân phải cầm giấy chạy qua lại.
    - **Duyệt & Kiểm tra Lâm sàng (Clinical Verification):**
        - Dược sĩ mở đơn thuốc, hệ thống hiển thị kèm thông tin tuổi, (cân nặng/chiều cao - _nếu bạn sửa DB_) của bệnh nhân để dược sĩ kiểm tra liều lượng có phù hợp không.
        - Nếu ổn, bấm "Duyệt" -> Trạng thái đơn chuyển sang `verified`, điền tên dược sĩ duyệt.
    - **Cấp phát & Trừ kho tự động (Dispensing & Auto-Inventory):**
        - Khi giao thuốc cho bệnh nhân, bấm "Hoàn tất cấp phát" -> Trạng thái chuyển sang `dispensed`.
        - Hệ thống tự động trừ số lượng thuốc tương ứng trong cột `stock_quantity` của bảng `Medications`.    
    - **Cảnh báo tồn kho (Low Stock Alert):** Báo cáo các loại thuốc sắp hết hàng dựa trên `stock_quantity`.
