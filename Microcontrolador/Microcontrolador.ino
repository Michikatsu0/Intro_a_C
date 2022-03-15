void setup() {
  Serial.begin(115200);
}

void loop() {
  if(Serial.available()){
    if(Serial.read() == '1'){
      delay(1000);
      Serial.print("Hello from ESP32\n");
    }
  }
}
