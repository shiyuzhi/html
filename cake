*::before,
*::after {
  padding: 0;
  margin: 0;
  box-sizing: border-box;
}
body {
  background-color: #ff0000;
}
.container {
  width: 400px;
  height: 400px;
  background-color: #ffffff;
  position: absolute;
  transform: translate(-50%, -50%);
  top: 50%;
  left: 50%;
  border-radius: 50px;
  box-shadow: 10px 20px 45px #31220a40;
}
.cake {
  width: 100%;
  position: absolute;
  bottom: 60px;
}
.bottom-layer,
.top-layer,
.middle-layer {
  height: 80px;
  width: 240px;
  position: relative;
  margin: auto;
  background-repeat: repeat;
  background-size: 100% 100%, 60px 100px;
  background-position: 28px 0;
  border-radius: 10px;
  background-image: linear-gradient(
      transparent 50px,
      #fffcfc 50px,
      #e3538a 60px,
      transparent 60px
    ),
    radial-gradient(circle at 30px 5px, #22fddc 30px, #f9ff7f 31px);
}
.middle-layer {
  transform: scale(0.85);
  top: 64px;
  animation: rise-1 2s forwards;
  border-radius: 10%;
}
@keyframes rise-1 {
  100% {
    top: 7px;
  }
}
.top-layer {
  transform: scale(0.7);
  top: 144px;
  animation: rise-2 2s 2s forwards;
}
@keyframes rise-2 {
  100% {
    top: 25px;
  }
}
.candle {
  background: repeating-linear-gradient(
    45deg,
    #fd3018 0,
    #fd3018 5px,
    #ffa89e 5px,
    #ffa89e 10px
  );
  height: 45px;
  width: 15px;
  position: absolute;
  margin: auto;
  left: 0;
  right: 0;
  bottom: 0;
  animation: rise-3 0.5s 3s forwards;
}
@keyframes rise-3 {
  100% {
    bottom: 202px;
  }
}
.candle:after {
  content: "";
  position: absolute;
  height: 16px;
  width: 16px;
  background-color: #f8ea6f;
  border-radius: 0 50% 50% 50%;
  transform: scale(0) rotate(45deg);
  bottom: 50px;
  left: -0.5px;
  animation: flame 0.5s 1s forwards;
}

.text{
    height: 500px;
    text-align: center ;
}

@keyframes flame {
  100% {
    transform: scale(1) rotate(45deg);
  }
}
