namespace UI {
    partial class frmMidiController {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::UI.frmMidiController));
            this.panel1 = (new global::UI.Controls.Panel());
            this.kVco1Freq = (new global::UI.Controls.Knob());
            this.kVco1Octave = (new global::UI.Controls.Knob());
            this.kVco1PW = (new global::UI.Controls.Knob());
            this.kVco1Waveform = (new global::UI.Controls.Knob());
            this.kVco2Waveform = (new global::UI.Controls.Knob());
            this.kVco2PW = (new global::UI.Controls.Knob());
            this.kVco2Octave = (new global::UI.Controls.Knob());
            this.kVco2Freq = (new global::UI.Controls.Knob());
            this.panel2 = (new global::UI.Controls.Panel());
            this.kVco3Waveform = (new global::UI.Controls.Knob());
            this.kVco3PW = (new global::UI.Controls.Knob());
            this.kVco3Octave = (new global::UI.Controls.Knob());
            this.kVco3Freq = (new global::UI.Controls.Knob());
            this.panel3 = (new global::UI.Controls.Panel());
            this.panel4 = (new global::UI.Controls.Panel());
            this.kOsc1Mix = (new global::UI.Controls.Knob());
            this.kOsc2Mix = (new global::UI.Controls.Knob());
            this.kOsc3Mix = (new global::UI.Controls.Knob());
            this.panel5 = (new global::UI.Controls.Panel());
            this.panel6 = (new global::UI.Controls.Panel());
            this.kVcfType = (new global::UI.Controls.Knob());
            this.kVcfCutoff = (new global::UI.Controls.Knob());
            this.kVcfResonance = (new global::UI.Controls.Knob());
            this.kVcfEnvelope = (new global::UI.Controls.Knob());
            this.kEnv1Release = (new global::UI.Controls.Knob());
            this.kEnv1Sustain = (new global::UI.Controls.Knob());
            this.kEnv1Decay = (new global::UI.Controls.Knob());
            this.kEnv1Attack = (new global::UI.Controls.Knob());
            this.kEnv2Release = (new global::UI.Controls.Knob());
            this.kEnv2Sustain = (new global::UI.Controls.Knob());
            this.kEnv2Decay = (new global::UI.Controls.Knob());
            this.kEnv2Attack = (new global::UI.Controls.Knob());
            this.kGlide = (new global::UI.Controls.Knob());
            this.kNoiseMix = (new global::UI.Controls.Knob());
            this.panel7 = (new global::UI.Controls.Panel());
            this.kLfo1Shape = (new global::UI.Controls.Knob());
            this.kLfo1Rate = (new global::UI.Controls.Knob());
            this.kLfo2Shape = (new global::UI.Controls.Knob());
            this.kLfo2Rate = (new global::UI.Controls.Knob());
            this.kEnv3Release = (new global::UI.Controls.Knob());
            this.kEnv3Sustain = (new global::UI.Controls.Knob());
            this.kEnv3Decay = (new global::UI.Controls.Knob());
            this.kEnv3Attack = (new global::UI.Controls.Knob());
            this.panel9 = (new global::UI.Controls.Panel());
            this.pictureBox1 = (new global::System.Windows.Forms.PictureBox());
            this.lblFilterType = (new global::System.Windows.Forms.Label());
            this.cmdViewWave = (new global::System.Windows.Forms.Button());
            this.cmdInit = (new global::System.Windows.Forms.Button());
            this.lblMidiChannel = (new global::System.Windows.Forms.Label());
            this.label2 = (new global::System.Windows.Forms.Label());
            this.cboMidiChannel = (new global::System.Windows.Forms.ComboBox());
            this.ledGate1 = (new global::UI.Controls.Led());
            this.ledLfo1 = (new global::UI.Controls.Led());
            this.ledLfo2 = (new global::UI.Controls.Led());
            this.cmdControllers = (new global::System.Windows.Forms.Button());
            this.panel10 = (new global::UI.Controls.Panel());
            this.kEffectParam1 = (new global::UI.Controls.Knob());
            this.kEffectType = (new global::UI.Controls.Knob());
            this.kEffectMix = (new global::UI.Controls.Knob());
            this.kEffectParam2 = (new global::UI.Controls.Knob());
            this.lblEffectType = (new global::System.Windows.Forms.Label());
            this.panel11 = (new global::UI.Controls.Panel());
            this.kBitCrushSampleRate = (new global::UI.Controls.Knob());
            this.kBitCrushResolution = (new global::UI.Controls.Knob());
            this.ledVCO1 = (new global::UI.Controls.Led());
            this.ledVCO2 = (new global::UI.Controls.Led());
            this.ledVCO3 = (new global::UI.Controls.Led());
            this.ledLFO = (new global::UI.Controls.Led());
            this.ledMixer = (new global::UI.Controls.Led());
            this.ledVCF = (new global::UI.Controls.Led());
            this.ledEnv1 = (new global::UI.Controls.Led());
            this.ledBitCrush = (new global::UI.Controls.Led());
            this.ledEnv2 = (new global::UI.Controls.Led());
            this.ledEnv3 = (new global::UI.Controls.Led());
            this.ledEffects = (new global::UI.Controls.Led());
            this.label1 = (new global::System.Windows.Forms.Label());
            this.label3 = (new global::System.Windows.Forms.Label());
            this.panel8 = (new global::UI.Controls.Panel());
            this.label4 = (new global::System.Windows.Forms.Label());
            this.label5 = (new global::System.Windows.Forms.Label());
            this.triangle1 = (new global::UI.Controls.Triangle());
            this.kVca2 = (new global::UI.Controls.Knob());
            this.triangle2 = (new global::UI.Controls.Triangle());
            this.kVca3 = (new global::UI.Controls.Knob());
            this.triangle3 = (new global::UI.Controls.Triangle());
            this.kVca4 = (new global::UI.Controls.Knob());
            this.rect1 = (new global::UI.Controls.Rect());
            this.rect2 = (new global::UI.Controls.Rect());
            this.rect3 = (new global::UI.Controls.Rect());
            this.rect4 = (new global::UI.Controls.Rect());
            this.rect5 = (new global::UI.Controls.Rect());
            this.rect6 = (new global::UI.Controls.Rect());
            this.rect7 = (new global::UI.Controls.Rect());
            this.rect8 = (new global::UI.Controls.Rect());
            this.rect9 = (new global::UI.Controls.Rect());
            this.rect10 = (new global::UI.Controls.Rect());
            this.rect11 = (new global::UI.Controls.Rect());
            this.rect12 = (new global::UI.Controls.Rect());
            this.label6 = (new global::System.Windows.Forms.Label());
            this.label7 = (new global::System.Windows.Forms.Label());
            this.label8 = (new global::System.Windows.Forms.Label());
            this.label9 = (new global::System.Windows.Forms.Label());
            this.label10 = (new global::System.Windows.Forms.Label());
            this.label11 = (new global::System.Windows.Forms.Label());
            this.label12 = (new global::System.Windows.Forms.Label());
            this.label13 = (new global::System.Windows.Forms.Label());
            this.label14 = (new global::System.Windows.Forms.Label());
            this.label15 = (new global::System.Windows.Forms.Label());
            this.label16 = (new global::System.Windows.Forms.Label());
            this.label17 = (new global::System.Windows.Forms.Label());
            this.rect13 = (new global::UI.Controls.Rect());
            this.rect14 = (new global::UI.Controls.Rect());
            this.rect15 = (new global::UI.Controls.Rect());
            this.rect16 = (new global::UI.Controls.Rect());
            this.triangle4 = (new global::UI.Controls.Triangle());
            this.kVca5 = (new global::UI.Controls.Knob());
            this.ledVcas = (new global::UI.Controls.Led());
            this.label18 = (new global::System.Windows.Forms.Label());
            this.label19 = (new global::System.Windows.Forms.Label());
            this.label20 = (new global::System.Windows.Forms.Label());
            this.label21 = (new global::System.Windows.Forms.Label());
            this.label22 = (new global::System.Windows.Forms.Label());
            this.label23 = (new global::System.Windows.Forms.Label());
            this.label24 = (new global::System.Windows.Forms.Label());
            this.label25 = (new global::System.Windows.Forms.Label());
            this.label26 = (new global::System.Windows.Forms.Label());
            this.label27 = (new global::System.Windows.Forms.Label());
            this.label33 = (new global::System.Windows.Forms.Label());
            this.label34 = (new global::System.Windows.Forms.Label());
            this.label35 = (new global::System.Windows.Forms.Label());
            this.label28 = (new global::System.Windows.Forms.Label());
            this.label29 = (new global::System.Windows.Forms.Label());
            this.label30 = (new global::System.Windows.Forms.Label());
            this.label31 = (new global::System.Windows.Forms.Label());
            this.label32 = (new global::System.Windows.Forms.Label());
            this.label36 = (new global::System.Windows.Forms.Label());
            this.label37 = (new global::System.Windows.Forms.Label());
            this.label38 = (new global::System.Windows.Forms.Label());
            this.label39 = (new global::System.Windows.Forms.Label());
            this.label40 = (new global::System.Windows.Forms.Label());
            this.label41 = (new global::System.Windows.Forms.Label());
            this.label42 = (new global::System.Windows.Forms.Label());
            this.label43 = (new global::System.Windows.Forms.Label());
            this.label44 = (new global::System.Windows.Forms.Label());
            this.label45 = (new global::System.Windows.Forms.Label());
            this.label46 = (new global::System.Windows.Forms.Label());
            this.label47 = (new global::System.Windows.Forms.Label());
            this.label48 = (new global::System.Windows.Forms.Label());
            this.label49 = (new global::System.Windows.Forms.Label());
            this.label50 = (new global::System.Windows.Forms.Label());
            this.label51 = (new global::System.Windows.Forms.Label());
            this.label52 = (new global::System.Windows.Forms.Label());
            this.label53 = (new global::System.Windows.Forms.Label());
            this.ledEnv4 = (new global::UI.Controls.Led());
            this.kEnv4Release = (new global::UI.Controls.Knob());
            this.kEnv4Sustain = (new global::UI.Controls.Knob());
            this.kEnv4Decay = (new global::UI.Controls.Knob());
            this.kEnv4Attack = (new global::UI.Controls.Knob());
            this.panel12 = (new global::UI.Controls.Panel());
            this.label54 = (new global::System.Windows.Forms.Label());
            this.label55 = (new global::System.Windows.Forms.Label());
            this.label56 = (new global::System.Windows.Forms.Label());
            this.label57 = (new global::System.Windows.Forms.Label());
            this.label58 = (new global::System.Windows.Forms.Label());
            this.label59 = (new global::System.Windows.Forms.Label());
            this.ledGate2 = (new global::UI.Controls.Led());
            this.ledGate3 = (new global::UI.Controls.Led());
            this.ledGate4 = (new global::UI.Controls.Led());
            this.ledGate5 = (new global::UI.Controls.Led());
            ((global::System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.CornerRadius = (10);
            this.panel1.ID = ("VCO1");
            this.panel1.LabelText = ("OSCILLATOR VCO1");
            this.panel1.LineWidth = (2);
            this.panel1.Location = (new global::System.Drawing.Point(6, 2));
            this.panel1.Name = ("panel1");
            this.panel1.Selected = (false);
            this.panel1.Size = (new global::System.Drawing.Size(323, 105));
            this.panel1.TabIndex = (0);
            // 
            // kVco1Freq
            // 
            this.kVco1Freq._v = (0D);
            this.kVco1Freq.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco1Freq.BackgroundImage")));
            this.kVco1Freq.BackgroundImageLayout = (global::System.Windows.Forms.ImageLayout.None);
            this.kVco1Freq.Default = (0D);
            this.kVco1Freq.Description = ("VCO1 Frequency");
            this.kVco1Freq.Divisions = (10);
            this.kVco1Freq.ForeColor = (global::System.Drawing.Color.White);
            this.kVco1Freq.HideLabels = (false);
            this.kVco1Freq.HideOutine = (true);
            this.kVco1Freq.HideTicks = (true);
            this.kVco1Freq.LabelMarker0 = ("-1");
            this.kVco1Freq.LabelMarker10 = ("+1");
            this.kVco1Freq.LabelMarker5 = ("0");
            this.kVco1Freq.LabelText = ("FREQUENCY");
            this.kVco1Freq.LimitToInteger = (false);
            this.kVco1Freq.Location = (new global::System.Drawing.Point(10, 20));
            this.kVco1Freq.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco1Freq.Max = (0.083333D);
            this.kVco1Freq.Min = (-0.083333D);
            this.kVco1Freq.Name = ("kVco1Freq");
            this.kVco1Freq.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco1Freq.SweepAngle = (270);
            this.kVco1Freq.TabIndex = (1);
            this.kVco1Freq.Thickness = (2);
            this.kVco1Freq.Value = (0D);
            // 
            // kVco1Octave
            // 
            this.kVco1Octave._v = (0D);
            this.kVco1Octave.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco1Octave.BackgroundImage")));
            this.kVco1Octave.BackgroundImageLayout = (global::System.Windows.Forms.ImageLayout.None);
            this.kVco1Octave.Default = (0D);
            this.kVco1Octave.Description = ("VCO1 Octave");
            this.kVco1Octave.Divisions = (3);
            this.kVco1Octave.ForeColor = (global::System.Drawing.Color.White);
            this.kVco1Octave.HideLabels = (true);
            this.kVco1Octave.HideOutine = (false);
            this.kVco1Octave.HideTicks = (true);
            this.kVco1Octave.LabelMarker0 = ("0");
            this.kVco1Octave.LabelMarker10 = ("10");
            this.kVco1Octave.LabelMarker5 = ("5");
            this.kVco1Octave.LabelText = ("OCTAVE");
            this.kVco1Octave.LimitToInteger = (true);
            this.kVco1Octave.Location = (new global::System.Drawing.Point(84, 20));
            this.kVco1Octave.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco1Octave.Max = (3D);
            this.kVco1Octave.Min = (0D);
            this.kVco1Octave.Name = ("kVco1Octave");
            this.kVco1Octave.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco1Octave.SweepAngle = (137);
            this.kVco1Octave.TabIndex = (2);
            this.kVco1Octave.Thickness = (2);
            this.kVco1Octave.Value = (0D);
            // 
            // kVco1PW
            // 
            this.kVco1PW._v = (0D);
            this.kVco1PW.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco1PW.BackgroundImage")));
            this.kVco1PW.Default = (0D);
            this.kVco1PW.Description = ("VCO1 Pule Width/Phase Dist.");
            this.kVco1PW.Divisions = (10);
            this.kVco1PW.ForeColor = (global::System.Drawing.Color.White);
            this.kVco1PW.HideLabels = (false);
            this.kVco1PW.HideOutine = (false);
            this.kVco1PW.HideTicks = (true);
            this.kVco1PW.LabelMarker0 = ("0");
            this.kVco1PW.LabelMarker10 = ("10");
            this.kVco1PW.LabelMarker5 = ("");
            this.kVco1PW.LabelText = ("PULSE WIDTH");
            this.kVco1PW.LimitToInteger = (false);
            this.kVco1PW.Location = (new global::System.Drawing.Point(247, 20));
            this.kVco1PW.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco1PW.Max = (0.9D);
            this.kVco1PW.Min = (-0.9D);
            this.kVco1PW.Name = ("kVco1PW");
            this.kVco1PW.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco1PW.SweepAngle = (270);
            this.kVco1PW.TabIndex = (3);
            this.kVco1PW.Thickness = (2);
            this.kVco1PW.Value = (0D);
            // 
            // kVco1Waveform
            // 
            this.kVco1Waveform._v = (1D);
            this.kVco1Waveform.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco1Waveform.BackgroundImage")));
            this.kVco1Waveform.Default = (1D);
            this.kVco1Waveform.Description = ("VCO1 Waveform");
            this.kVco1Waveform.Divisions = (4);
            this.kVco1Waveform.ForeColor = (global::System.Drawing.Color.White);
            this.kVco1Waveform.HideLabels = (true);
            this.kVco1Waveform.HideOutine = (false);
            this.kVco1Waveform.HideTicks = (true);
            this.kVco1Waveform.LabelMarker0 = ("0");
            this.kVco1Waveform.LabelMarker10 = ("10");
            this.kVco1Waveform.LabelMarker5 = ("5");
            this.kVco1Waveform.LabelText = ("WAVEFORM");
            this.kVco1Waveform.LimitToInteger = (true);
            this.kVco1Waveform.Location = (new global::System.Drawing.Point(174, 20));
            this.kVco1Waveform.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco1Waveform.Max = (4D);
            this.kVco1Waveform.Min = (0D);
            this.kVco1Waveform.Name = ("kVco1Waveform");
            this.kVco1Waveform.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco1Waveform.SweepAngle = (135);
            this.kVco1Waveform.TabIndex = (4);
            this.kVco1Waveform.Thickness = (2);
            this.kVco1Waveform.Value = (1D);
            // 
            // kVco2Waveform
            // 
            this.kVco2Waveform._v = (1D);
            this.kVco2Waveform.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco2Waveform.BackgroundImage")));
            this.kVco2Waveform.Default = (1D);
            this.kVco2Waveform.Description = ("VCO2 Waveform");
            this.kVco2Waveform.Divisions = (4);
            this.kVco2Waveform.ForeColor = (global::System.Drawing.Color.White);
            this.kVco2Waveform.HideLabels = (true);
            this.kVco2Waveform.HideOutine = (false);
            this.kVco2Waveform.HideTicks = (true);
            this.kVco2Waveform.LabelMarker0 = ("0");
            this.kVco2Waveform.LabelMarker10 = ("10");
            this.kVco2Waveform.LabelMarker5 = ("5");
            this.kVco2Waveform.LabelText = ("WAVEFORM");
            this.kVco2Waveform.LimitToInteger = (true);
            this.kVco2Waveform.Location = (new global::System.Drawing.Point(174, 131));
            this.kVco2Waveform.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco2Waveform.Max = (4D);
            this.kVco2Waveform.Min = (0D);
            this.kVco2Waveform.Name = ("kVco2Waveform");
            this.kVco2Waveform.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco2Waveform.SweepAngle = (135);
            this.kVco2Waveform.TabIndex = (9);
            this.kVco2Waveform.Thickness = (2);
            this.kVco2Waveform.Value = (1D);
            // 
            // kVco2PW
            // 
            this.kVco2PW._v = (0D);
            this.kVco2PW.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco2PW.BackgroundImage")));
            this.kVco2PW.Default = (0D);
            this.kVco2PW.Description = ("VCO2 Pule Width/Phase Dist.");
            this.kVco2PW.Divisions = (10);
            this.kVco2PW.ForeColor = (global::System.Drawing.Color.White);
            this.kVco2PW.HideLabels = (false);
            this.kVco2PW.HideOutine = (false);
            this.kVco2PW.HideTicks = (true);
            this.kVco2PW.LabelMarker0 = ("0");
            this.kVco2PW.LabelMarker10 = ("10");
            this.kVco2PW.LabelMarker5 = ("");
            this.kVco2PW.LabelText = ("PULSE WIDTH");
            this.kVco2PW.LimitToInteger = (false);
            this.kVco2PW.Location = (new global::System.Drawing.Point(247, 131));
            this.kVco2PW.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco2PW.Max = (0.9D);
            this.kVco2PW.Min = (-0.9D);
            this.kVco2PW.Name = ("kVco2PW");
            this.kVco2PW.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco2PW.SweepAngle = (270);
            this.kVco2PW.TabIndex = (8);
            this.kVco2PW.Thickness = (2);
            this.kVco2PW.Value = (0D);
            // 
            // kVco2Octave
            // 
            this.kVco2Octave._v = (0D);
            this.kVco2Octave.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco2Octave.BackgroundImage")));
            this.kVco2Octave.BackgroundImageLayout = (global::System.Windows.Forms.ImageLayout.None);
            this.kVco2Octave.Default = (0D);
            this.kVco2Octave.Description = ("VCO2 Octave");
            this.kVco2Octave.Divisions = (3);
            this.kVco2Octave.ForeColor = (global::System.Drawing.Color.White);
            this.kVco2Octave.HideLabels = (true);
            this.kVco2Octave.HideOutine = (false);
            this.kVco2Octave.HideTicks = (true);
            this.kVco2Octave.LabelMarker0 = ("0");
            this.kVco2Octave.LabelMarker10 = ("10");
            this.kVco2Octave.LabelMarker5 = ("5");
            this.kVco2Octave.LabelText = ("OCTAVE");
            this.kVco2Octave.LimitToInteger = (true);
            this.kVco2Octave.Location = (new global::System.Drawing.Point(84, 131));
            this.kVco2Octave.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco2Octave.Max = (3D);
            this.kVco2Octave.Min = (0D);
            this.kVco2Octave.Name = ("kVco2Octave");
            this.kVco2Octave.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco2Octave.SweepAngle = (137);
            this.kVco2Octave.TabIndex = (7);
            this.kVco2Octave.Thickness = (2);
            this.kVco2Octave.Value = (0D);
            // 
            // kVco2Freq
            // 
            this.kVco2Freq._v = (-0.01D);
            this.kVco2Freq.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco2Freq.BackgroundImage")));
            this.kVco2Freq.Default = (0D);
            this.kVco2Freq.Description = ("VCO2 Frequency");
            this.kVco2Freq.Divisions = (10);
            this.kVco2Freq.ForeColor = (global::System.Drawing.Color.White);
            this.kVco2Freq.HideLabels = (false);
            this.kVco2Freq.HideOutine = (false);
            this.kVco2Freq.HideTicks = (true);
            this.kVco2Freq.LabelMarker0 = ("0");
            this.kVco2Freq.LabelMarker10 = ("10");
            this.kVco2Freq.LabelMarker5 = ("5");
            this.kVco2Freq.LabelText = ("FREQUENCY");
            this.kVco2Freq.LimitToInteger = (false);
            this.kVco2Freq.Location = (new global::System.Drawing.Point(10, 131));
            this.kVco2Freq.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco2Freq.Max = (0.083333D);
            this.kVco2Freq.Min = (-0.083333D);
            this.kVco2Freq.Name = ("kVco2Freq");
            this.kVco2Freq.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco2Freq.SweepAngle = (270);
            this.kVco2Freq.TabIndex = (6);
            this.kVco2Freq.Thickness = (2);
            this.kVco2Freq.Value = (-0.01D);
            // 
            // panel2
            // 
            this.panel2.CornerRadius = (10);
            this.panel2.ID = ("");
            this.panel2.LabelText = ("OSCILLATOR VCO2");
            this.panel2.LineWidth = (2);
            this.panel2.Location = (new global::System.Drawing.Point(6, 113));
            this.panel2.Name = ("panel2");
            this.panel2.Selected = (false);
            this.panel2.Size = (new global::System.Drawing.Size(323, 105));
            this.panel2.TabIndex = (5);
            // 
            // kVco3Waveform
            // 
            this.kVco3Waveform._v = (1D);
            this.kVco3Waveform.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco3Waveform.BackgroundImage")));
            this.kVco3Waveform.Default = (1D);
            this.kVco3Waveform.Description = ("VCO3 Waveform");
            this.kVco3Waveform.Divisions = (4);
            this.kVco3Waveform.ForeColor = (global::System.Drawing.Color.White);
            this.kVco3Waveform.HideLabels = (true);
            this.kVco3Waveform.HideOutine = (false);
            this.kVco3Waveform.HideTicks = (true);
            this.kVco3Waveform.LabelMarker0 = ("0");
            this.kVco3Waveform.LabelMarker10 = ("10");
            this.kVco3Waveform.LabelMarker5 = ("5");
            this.kVco3Waveform.LabelText = ("WAVEFORM");
            this.kVco3Waveform.LimitToInteger = (true);
            this.kVco3Waveform.Location = (new global::System.Drawing.Point(174, 242));
            this.kVco3Waveform.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco3Waveform.Max = (4D);
            this.kVco3Waveform.Min = (0D);
            this.kVco3Waveform.Name = ("kVco3Waveform");
            this.kVco3Waveform.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco3Waveform.SweepAngle = (135);
            this.kVco3Waveform.TabIndex = (14);
            this.kVco3Waveform.Thickness = (2);
            this.kVco3Waveform.Value = (1D);
            // 
            // kVco3PW
            // 
            this.kVco3PW._v = (0D);
            this.kVco3PW.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco3PW.BackgroundImage")));
            this.kVco3PW.Default = (0D);
            this.kVco3PW.Description = ("VCO3 Pule Width/Phase Dist.");
            this.kVco3PW.Divisions = (10);
            this.kVco3PW.ForeColor = (global::System.Drawing.Color.White);
            this.kVco3PW.HideLabels = (false);
            this.kVco3PW.HideOutine = (false);
            this.kVco3PW.HideTicks = (true);
            this.kVco3PW.LabelMarker0 = ("0");
            this.kVco3PW.LabelMarker10 = ("10");
            this.kVco3PW.LabelMarker5 = ("");
            this.kVco3PW.LabelText = ("PULSE WIDTH");
            this.kVco3PW.LimitToInteger = (false);
            this.kVco3PW.Location = (new global::System.Drawing.Point(247, 242));
            this.kVco3PW.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco3PW.Max = (0.9D);
            this.kVco3PW.Min = (-0.9D);
            this.kVco3PW.Name = ("kVco3PW");
            this.kVco3PW.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco3PW.SweepAngle = (270);
            this.kVco3PW.TabIndex = (13);
            this.kVco3PW.Thickness = (2);
            this.kVco3PW.Value = (0D);
            // 
            // kVco3Octave
            // 
            this.kVco3Octave._v = (1D);
            this.kVco3Octave.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco3Octave.BackgroundImage")));
            this.kVco3Octave.Default = (1D);
            this.kVco3Octave.Description = ("VCO3 Octave");
            this.kVco3Octave.Divisions = (3);
            this.kVco3Octave.ForeColor = (global::System.Drawing.Color.White);
            this.kVco3Octave.HideLabels = (true);
            this.kVco3Octave.HideOutine = (false);
            this.kVco3Octave.HideTicks = (true);
            this.kVco3Octave.LabelMarker0 = ("0");
            this.kVco3Octave.LabelMarker10 = ("10");
            this.kVco3Octave.LabelMarker5 = ("5");
            this.kVco3Octave.LabelText = ("OCTAVE");
            this.kVco3Octave.LimitToInteger = (true);
            this.kVco3Octave.Location = (new global::System.Drawing.Point(84, 242));
            this.kVco3Octave.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco3Octave.Max = (3D);
            this.kVco3Octave.Min = (0D);
            this.kVco3Octave.Name = ("kVco3Octave");
            this.kVco3Octave.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco3Octave.SweepAngle = (137);
            this.kVco3Octave.TabIndex = (12);
            this.kVco3Octave.Thickness = (2);
            this.kVco3Octave.Value = (1D);
            // 
            // kVco3Freq
            // 
            this.kVco3Freq._v = (0.01D);
            this.kVco3Freq.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVco3Freq.BackgroundImage")));
            this.kVco3Freq.Default = (0.01D);
            this.kVco3Freq.Description = ("VCO3 Frequency");
            this.kVco3Freq.Divisions = (10);
            this.kVco3Freq.ForeColor = (global::System.Drawing.Color.White);
            this.kVco3Freq.HideLabels = (false);
            this.kVco3Freq.HideOutine = (false);
            this.kVco3Freq.HideTicks = (true);
            this.kVco3Freq.LabelMarker0 = ("0");
            this.kVco3Freq.LabelMarker10 = ("10");
            this.kVco3Freq.LabelMarker5 = ("5");
            this.kVco3Freq.LabelText = ("FREQUENCY");
            this.kVco3Freq.LimitToInteger = (false);
            this.kVco3Freq.Location = (new global::System.Drawing.Point(10, 242));
            this.kVco3Freq.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVco3Freq.Max = (0.083333D);
            this.kVco3Freq.Min = (-0.083333D);
            this.kVco3Freq.Name = ("kVco3Freq");
            this.kVco3Freq.Size = (new global::System.Drawing.Size(77, 77));
            this.kVco3Freq.SweepAngle = (270);
            this.kVco3Freq.TabIndex = (11);
            this.kVco3Freq.Thickness = (2);
            this.kVco3Freq.Value = (0.01D);
            // 
            // panel3
            // 
            this.panel3.CornerRadius = (10);
            this.panel3.ID = ("");
            this.panel3.LabelText = ("OSCILLATOR VCO3");
            this.panel3.LineWidth = (2);
            this.panel3.Location = (new global::System.Drawing.Point(6, 224));
            this.panel3.Name = ("panel3");
            this.panel3.Selected = (false);
            this.panel3.Size = (new global::System.Drawing.Size(323, 105));
            this.panel3.TabIndex = (10);
            // 
            // panel4
            // 
            this.panel4.CornerRadius = (10);
            this.panel4.ID = ("Mixer");
            this.panel4.LabelText = ("MIXER");
            this.panel4.LineWidth = (2);
            this.panel4.Location = (new global::System.Drawing.Point(334, 2));
            this.panel4.Name = ("panel4");
            this.panel4.Selected = (false);
            this.panel4.Size = (new global::System.Drawing.Size(92, 436));
            this.panel4.TabIndex = (15);
            // 
            // kOsc1Mix
            // 
            this.kOsc1Mix._v = (1D);
            this.kOsc1Mix.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kOsc1Mix.BackgroundImage")));
            this.kOsc1Mix.Default = (1D);
            this.kOsc1Mix.Description = ("Mixer VCO1");
            this.kOsc1Mix.Divisions = (10);
            this.kOsc1Mix.ForeColor = (global::System.Drawing.Color.White);
            this.kOsc1Mix.HideLabels = (false);
            this.kOsc1Mix.HideOutine = (false);
            this.kOsc1Mix.HideTicks = (true);
            this.kOsc1Mix.LabelMarker0 = ("0");
            this.kOsc1Mix.LabelMarker10 = ("10");
            this.kOsc1Mix.LabelMarker5 = ("");
            this.kOsc1Mix.LabelText = ("OSC 1");
            this.kOsc1Mix.LimitToInteger = (false);
            this.kOsc1Mix.Location = (new global::System.Drawing.Point(340, 19));
            this.kOsc1Mix.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kOsc1Mix.Max = (1D);
            this.kOsc1Mix.Min = (0D);
            this.kOsc1Mix.Name = ("kOsc1Mix");
            this.kOsc1Mix.Size = (new global::System.Drawing.Size(77, 77));
            this.kOsc1Mix.SweepAngle = (270);
            this.kOsc1Mix.TabIndex = (16);
            this.kOsc1Mix.Thickness = (2);
            this.kOsc1Mix.Value = (1D);
            // 
            // kOsc2Mix
            // 
            this.kOsc2Mix._v = (1D);
            this.kOsc2Mix.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kOsc2Mix.BackgroundImage")));
            this.kOsc2Mix.Default = (1D);
            this.kOsc2Mix.Description = ("Mixer VCO2");
            this.kOsc2Mix.Divisions = (10);
            this.kOsc2Mix.ForeColor = (global::System.Drawing.Color.White);
            this.kOsc2Mix.HideLabels = (false);
            this.kOsc2Mix.HideOutine = (false);
            this.kOsc2Mix.HideTicks = (true);
            this.kOsc2Mix.LabelMarker0 = ("0");
            this.kOsc2Mix.LabelMarker10 = ("10");
            this.kOsc2Mix.LabelMarker5 = ("");
            this.kOsc2Mix.LabelText = ("OSC 2");
            this.kOsc2Mix.LimitToInteger = (false);
            this.kOsc2Mix.Location = (new global::System.Drawing.Point(340, 131));
            this.kOsc2Mix.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kOsc2Mix.Max = (1D);
            this.kOsc2Mix.Min = (0D);
            this.kOsc2Mix.Name = ("kOsc2Mix");
            this.kOsc2Mix.Size = (new global::System.Drawing.Size(77, 77));
            this.kOsc2Mix.SweepAngle = (270);
            this.kOsc2Mix.TabIndex = (17);
            this.kOsc2Mix.Thickness = (2);
            this.kOsc2Mix.Value = (1D);
            // 
            // kOsc3Mix
            // 
            this.kOsc3Mix._v = (1D);
            this.kOsc3Mix.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kOsc3Mix.BackgroundImage")));
            this.kOsc3Mix.Default = (1D);
            this.kOsc3Mix.Description = ("Mixer VCO3");
            this.kOsc3Mix.Divisions = (10);
            this.kOsc3Mix.ForeColor = (global::System.Drawing.Color.White);
            this.kOsc3Mix.HideLabels = (false);
            this.kOsc3Mix.HideOutine = (false);
            this.kOsc3Mix.HideTicks = (true);
            this.kOsc3Mix.LabelMarker0 = ("0");
            this.kOsc3Mix.LabelMarker10 = ("10");
            this.kOsc3Mix.LabelMarker5 = ("");
            this.kOsc3Mix.LabelText = ("OSC 3");
            this.kOsc3Mix.LimitToInteger = (false);
            this.kOsc3Mix.Location = (new global::System.Drawing.Point(341, 242));
            this.kOsc3Mix.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kOsc3Mix.Max = (1D);
            this.kOsc3Mix.Min = (0D);
            this.kOsc3Mix.Name = ("kOsc3Mix");
            this.kOsc3Mix.Size = (new global::System.Drawing.Size(77, 77));
            this.kOsc3Mix.SweepAngle = (270);
            this.kOsc3Mix.TabIndex = (18);
            this.kOsc3Mix.Thickness = (2);
            this.kOsc3Mix.Value = (1D);
            // 
            // panel5
            // 
            this.panel5.BackColor = (global::System.Drawing.Color.Navy);
            this.panel5.CornerRadius = (10);
            this.panel5.ID = ("");
            this.panel5.LabelText = ("FILTER VCF - ENV 1");
            this.panel5.LineWidth = (2);
            this.panel5.Location = (new global::System.Drawing.Point(526, 3));
            this.panel5.Name = ("panel5");
            this.panel5.Selected = (false);
            this.panel5.Size = (new global::System.Drawing.Size(307, 215));
            this.panel5.TabIndex = (19);
            // 
            // panel6
            // 
            this.panel6.CornerRadius = (10);
            this.panel6.ID = ("");
            this.panel6.LabelText = ("AMPLIFIER VCA1 - ENV 2");
            this.panel6.LineWidth = (2);
            this.panel6.Location = (new global::System.Drawing.Point(526, 224));
            this.panel6.Name = ("panel6");
            this.panel6.Selected = (false);
            this.panel6.Size = (new global::System.Drawing.Size(307, 105));
            this.panel6.TabIndex = (20);
            // 
            // kVcfType
            // 
            this.kVcfType._v = (1D);
            this.kVcfType.BackColor = (global::System.Drawing.Color.Navy);
            this.kVcfType.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVcfType.BackgroundImage")));
            this.kVcfType.Default = (1D);
            this.kVcfType.Description = ("VCF Type");
            this.kVcfType.Divisions = (5);
            this.kVcfType.ForeColor = (global::System.Drawing.Color.White);
            this.kVcfType.HideLabels = (true);
            this.kVcfType.HideOutine = (false);
            this.kVcfType.HideTicks = (true);
            this.kVcfType.LabelMarker0 = ("0");
            this.kVcfType.LabelMarker10 = ("10");
            this.kVcfType.LabelMarker5 = ("5");
            this.kVcfType.LabelText = ("TYPE");
            this.kVcfType.LimitToInteger = (true);
            this.kVcfType.Location = (new global::System.Drawing.Point(530, 20));
            this.kVcfType.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVcfType.Max = (5D);
            this.kVcfType.Min = (0D);
            this.kVcfType.Name = ("kVcfType");
            this.kVcfType.Size = (new global::System.Drawing.Size(77, 77));
            this.kVcfType.SweepAngle = (180);
            this.kVcfType.TabIndex = (21);
            this.kVcfType.Thickness = (2);
            this.kVcfType.Value = (1D);
            // 
            // kVcfCutoff
            // 
            this.kVcfCutoff._v = (0D);
            this.kVcfCutoff.BackColor = (global::System.Drawing.Color.Navy);
            this.kVcfCutoff.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVcfCutoff.BackgroundImage")));
            this.kVcfCutoff.Default = (0D);
            this.kVcfCutoff.Description = ("VCF Cutoff");
            this.kVcfCutoff.Divisions = (10);
            this.kVcfCutoff.ForeColor = (global::System.Drawing.Color.White);
            this.kVcfCutoff.HideLabels = (false);
            this.kVcfCutoff.HideOutine = (true);
            this.kVcfCutoff.HideTicks = (true);
            this.kVcfCutoff.LabelMarker0 = ("0");
            this.kVcfCutoff.LabelMarker10 = ("10");
            this.kVcfCutoff.LabelMarker5 = ("");
            this.kVcfCutoff.LabelText = ("CUTOFF");
            this.kVcfCutoff.LimitToInteger = (false);
            this.kVcfCutoff.Location = (new global::System.Drawing.Point(604, 20));
            this.kVcfCutoff.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVcfCutoff.Max = (1D);
            this.kVcfCutoff.Min = (0D);
            this.kVcfCutoff.Name = ("kVcfCutoff");
            this.kVcfCutoff.Size = (new global::System.Drawing.Size(77, 77));
            this.kVcfCutoff.SweepAngle = (270);
            this.kVcfCutoff.TabIndex = (22);
            this.kVcfCutoff.Thickness = (2);
            this.kVcfCutoff.Value = (0D);
            // 
            // kVcfResonance
            // 
            this.kVcfResonance._v = (1D);
            this.kVcfResonance.BackColor = (global::System.Drawing.Color.Navy);
            this.kVcfResonance.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVcfResonance.BackgroundImage")));
            this.kVcfResonance.Default = (1D);
            this.kVcfResonance.Description = ("VCF Resonance");
            this.kVcfResonance.Divisions = (10);
            this.kVcfResonance.ForeColor = (global::System.Drawing.Color.White);
            this.kVcfResonance.HideLabels = (false);
            this.kVcfResonance.HideOutine = (true);
            this.kVcfResonance.HideTicks = (true);
            this.kVcfResonance.LabelMarker0 = ("0");
            this.kVcfResonance.LabelMarker10 = ("10");
            this.kVcfResonance.LabelMarker5 = ("");
            this.kVcfResonance.LabelText = ("RESONANCE");
            this.kVcfResonance.LimitToInteger = (false);
            this.kVcfResonance.Location = (new global::System.Drawing.Point(678, 20));
            this.kVcfResonance.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVcfResonance.Max = (1D);
            this.kVcfResonance.Min = (0D);
            this.kVcfResonance.Name = ("kVcfResonance");
            this.kVcfResonance.Size = (new global::System.Drawing.Size(77, 77));
            this.kVcfResonance.SweepAngle = (270);
            this.kVcfResonance.TabIndex = (23);
            this.kVcfResonance.Thickness = (2);
            this.kVcfResonance.Value = (1D);
            // 
            // kVcfEnvelope
            // 
            this.kVcfEnvelope._v = (1D);
            this.kVcfEnvelope.BackColor = (global::System.Drawing.Color.Navy);
            this.kVcfEnvelope.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kVcfEnvelope.BackgroundImage")));
            this.kVcfEnvelope.Default = (1D);
            this.kVcfEnvelope.Description = ("VCF Envelope Amount");
            this.kVcfEnvelope.Divisions = (10);
            this.kVcfEnvelope.ForeColor = (global::System.Drawing.Color.White);
            this.kVcfEnvelope.HideLabels = (false);
            this.kVcfEnvelope.HideOutine = (true);
            this.kVcfEnvelope.HideTicks = (true);
            this.kVcfEnvelope.LabelMarker0 = ("0");
            this.kVcfEnvelope.LabelMarker10 = ("10");
            this.kVcfEnvelope.LabelMarker5 = ("");
            this.kVcfEnvelope.LabelText = ("ENVELOPE");
            this.kVcfEnvelope.LimitToInteger = (false);
            this.kVcfEnvelope.Location = (new global::System.Drawing.Point(752, 20));
            this.kVcfEnvelope.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVcfEnvelope.Max = (1D);
            this.kVcfEnvelope.Min = (0D);
            this.kVcfEnvelope.Name = ("kVcfEnvelope");
            this.kVcfEnvelope.Size = (new global::System.Drawing.Size(77, 77));
            this.kVcfEnvelope.SweepAngle = (270);
            this.kVcfEnvelope.TabIndex = (24);
            this.kVcfEnvelope.Thickness = (2);
            this.kVcfEnvelope.Value = (1D);
            // 
            // kEnv1Release
            // 
            this.kEnv1Release._v = (2D);
            this.kEnv1Release.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv1Release.BackgroundImage")));
            this.kEnv1Release.Default = (2D);
            this.kEnv1Release.Description = ("VCF Envelope - Release");
            this.kEnv1Release.Divisions = (10);
            this.kEnv1Release.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv1Release.HideLabels = (false);
            this.kEnv1Release.HideOutine = (true);
            this.kEnv1Release.HideTicks = (true);
            this.kEnv1Release.LabelMarker0 = ("0");
            this.kEnv1Release.LabelMarker10 = ("10");
            this.kEnv1Release.LabelMarker5 = ("");
            this.kEnv1Release.LabelText = ("RELEASE");
            this.kEnv1Release.LimitToInteger = (false);
            this.kEnv1Release.Location = (new global::System.Drawing.Point(753, 131));
            this.kEnv1Release.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv1Release.Max = (5D);
            this.kEnv1Release.Min = (0D);
            this.kEnv1Release.Name = ("kEnv1Release");
            this.kEnv1Release.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv1Release.SweepAngle = (270);
            this.kEnv1Release.TabIndex = (28);
            this.kEnv1Release.Thickness = (2);
            this.kEnv1Release.Value = (2D);
            // 
            // kEnv1Sustain
            // 
            this.kEnv1Sustain._v = (0.6D);
            this.kEnv1Sustain.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv1Sustain.BackgroundImage")));
            this.kEnv1Sustain.Default = (0.6D);
            this.kEnv1Sustain.Description = ("VCF Envelope - Sustain");
            this.kEnv1Sustain.Divisions = (10);
            this.kEnv1Sustain.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv1Sustain.HideLabels = (false);
            this.kEnv1Sustain.HideOutine = (true);
            this.kEnv1Sustain.HideTicks = (true);
            this.kEnv1Sustain.LabelMarker0 = ("0");
            this.kEnv1Sustain.LabelMarker10 = ("10");
            this.kEnv1Sustain.LabelMarker5 = ("");
            this.kEnv1Sustain.LabelText = ("SUSTAIN");
            this.kEnv1Sustain.LimitToInteger = (false);
            this.kEnv1Sustain.Location = (new global::System.Drawing.Point(679, 131));
            this.kEnv1Sustain.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv1Sustain.Max = (1D);
            this.kEnv1Sustain.Min = (0D);
            this.kEnv1Sustain.Name = ("kEnv1Sustain");
            this.kEnv1Sustain.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv1Sustain.SweepAngle = (270);
            this.kEnv1Sustain.TabIndex = (27);
            this.kEnv1Sustain.Thickness = (2);
            this.kEnv1Sustain.Value = (0.6D);
            // 
            // kEnv1Decay
            // 
            this.kEnv1Decay._v = (0.5D);
            this.kEnv1Decay.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv1Decay.BackgroundImage")));
            this.kEnv1Decay.Default = (0.5D);
            this.kEnv1Decay.Description = ("VCF Envelope - Decay");
            this.kEnv1Decay.Divisions = (10);
            this.kEnv1Decay.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv1Decay.HideLabels = (false);
            this.kEnv1Decay.HideOutine = (true);
            this.kEnv1Decay.HideTicks = (true);
            this.kEnv1Decay.LabelMarker0 = ("0");
            this.kEnv1Decay.LabelMarker10 = ("10");
            this.kEnv1Decay.LabelMarker5 = ("");
            this.kEnv1Decay.LabelText = ("DECAY");
            this.kEnv1Decay.LimitToInteger = (false);
            this.kEnv1Decay.Location = (new global::System.Drawing.Point(604, 131));
            this.kEnv1Decay.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv1Decay.Max = (5D);
            this.kEnv1Decay.Min = (0D);
            this.kEnv1Decay.Name = ("kEnv1Decay");
            this.kEnv1Decay.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv1Decay.SweepAngle = (270);
            this.kEnv1Decay.TabIndex = (26);
            this.kEnv1Decay.Thickness = (2);
            this.kEnv1Decay.Value = (0.5D);
            // 
            // kEnv1Attack
            // 
            this.kEnv1Attack._v = (0D);
            this.kEnv1Attack.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv1Attack.BackgroundImage")));
            this.kEnv1Attack.Default = (0D);
            this.kEnv1Attack.Description = ("VCF Envelope - Attack");
            this.kEnv1Attack.Divisions = (10);
            this.kEnv1Attack.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv1Attack.HideLabels = (false);
            this.kEnv1Attack.HideOutine = (true);
            this.kEnv1Attack.HideTicks = (true);
            this.kEnv1Attack.LabelMarker0 = ("0");
            this.kEnv1Attack.LabelMarker10 = ("10");
            this.kEnv1Attack.LabelMarker5 = ("");
            this.kEnv1Attack.LabelText = ("ATTACK");
            this.kEnv1Attack.LimitToInteger = (false);
            this.kEnv1Attack.Location = (new global::System.Drawing.Point(530, 131));
            this.kEnv1Attack.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv1Attack.Max = (5D);
            this.kEnv1Attack.Min = (0D);
            this.kEnv1Attack.Name = ("kEnv1Attack");
            this.kEnv1Attack.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv1Attack.SweepAngle = (270);
            this.kEnv1Attack.TabIndex = (25);
            this.kEnv1Attack.Thickness = (2);
            this.kEnv1Attack.Value = (0D);
            // 
            // kEnv2Release
            // 
            this.kEnv2Release._v = (4D);
            this.kEnv2Release.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv2Release.BackgroundImage")));
            this.kEnv2Release.Default = (4D);
            this.kEnv2Release.Description = ("VCA Envelope - Release");
            this.kEnv2Release.Divisions = (10);
            this.kEnv2Release.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv2Release.HideLabels = (false);
            this.kEnv2Release.HideOutine = (true);
            this.kEnv2Release.HideTicks = (true);
            this.kEnv2Release.LabelMarker0 = ("0");
            this.kEnv2Release.LabelMarker10 = ("10");
            this.kEnv2Release.LabelMarker5 = ("");
            this.kEnv2Release.LabelText = ("RELEASE");
            this.kEnv2Release.LimitToInteger = (false);
            this.kEnv2Release.Location = (new global::System.Drawing.Point(752, 242));
            this.kEnv2Release.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv2Release.Max = (5D);
            this.kEnv2Release.Min = (0D);
            this.kEnv2Release.Name = ("kEnv2Release");
            this.kEnv2Release.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv2Release.SweepAngle = (270);
            this.kEnv2Release.TabIndex = (32);
            this.kEnv2Release.Thickness = (2);
            this.kEnv2Release.Value = (4D);
            // 
            // kEnv2Sustain
            // 
            this.kEnv2Sustain._v = (0.7D);
            this.kEnv2Sustain.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv2Sustain.BackgroundImage")));
            this.kEnv2Sustain.Default = (0.7D);
            this.kEnv2Sustain.Description = ("VCA Envelope - Sustain");
            this.kEnv2Sustain.Divisions = (10);
            this.kEnv2Sustain.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv2Sustain.HideLabels = (false);
            this.kEnv2Sustain.HideOutine = (true);
            this.kEnv2Sustain.HideTicks = (true);
            this.kEnv2Sustain.LabelMarker0 = ("0");
            this.kEnv2Sustain.LabelMarker10 = ("10");
            this.kEnv2Sustain.LabelMarker5 = ("");
            this.kEnv2Sustain.LabelText = ("SUSTAIN");
            this.kEnv2Sustain.LimitToInteger = (false);
            this.kEnv2Sustain.Location = (new global::System.Drawing.Point(678, 242));
            this.kEnv2Sustain.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv2Sustain.Max = (1D);
            this.kEnv2Sustain.Min = (0D);
            this.kEnv2Sustain.Name = ("kEnv2Sustain");
            this.kEnv2Sustain.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv2Sustain.SweepAngle = (270);
            this.kEnv2Sustain.TabIndex = (31);
            this.kEnv2Sustain.Thickness = (2);
            this.kEnv2Sustain.Value = (0.7D);
            // 
            // kEnv2Decay
            // 
            this.kEnv2Decay._v = (0.3D);
            this.kEnv2Decay.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv2Decay.BackgroundImage")));
            this.kEnv2Decay.Default = (0.3D);
            this.kEnv2Decay.Description = ("VCA Envelope - Decay");
            this.kEnv2Decay.Divisions = (10);
            this.kEnv2Decay.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv2Decay.HideLabels = (false);
            this.kEnv2Decay.HideOutine = (true);
            this.kEnv2Decay.HideTicks = (true);
            this.kEnv2Decay.LabelMarker0 = ("0");
            this.kEnv2Decay.LabelMarker10 = ("10");
            this.kEnv2Decay.LabelMarker5 = ("");
            this.kEnv2Decay.LabelText = ("DECAY");
            this.kEnv2Decay.LimitToInteger = (false);
            this.kEnv2Decay.Location = (new global::System.Drawing.Point(604, 242));
            this.kEnv2Decay.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv2Decay.Max = (5D);
            this.kEnv2Decay.Min = (0D);
            this.kEnv2Decay.Name = ("kEnv2Decay");
            this.kEnv2Decay.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv2Decay.SweepAngle = (270);
            this.kEnv2Decay.TabIndex = (30);
            this.kEnv2Decay.Thickness = (2);
            this.kEnv2Decay.Value = (0.3D);
            // 
            // kEnv2Attack
            // 
            this.kEnv2Attack._v = (0D);
            this.kEnv2Attack.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv2Attack.BackgroundImage")));
            this.kEnv2Attack.Default = (0D);
            this.kEnv2Attack.Description = ("VCA Envelope - Attack");
            this.kEnv2Attack.Divisions = (10);
            this.kEnv2Attack.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv2Attack.HideLabels = (false);
            this.kEnv2Attack.HideOutine = (true);
            this.kEnv2Attack.HideTicks = (true);
            this.kEnv2Attack.LabelMarker0 = ("0");
            this.kEnv2Attack.LabelMarker10 = ("10");
            this.kEnv2Attack.LabelMarker5 = ("");
            this.kEnv2Attack.LabelText = ("ATTACK");
            this.kEnv2Attack.LimitToInteger = (false);
            this.kEnv2Attack.Location = (new global::System.Drawing.Point(530, 242));
            this.kEnv2Attack.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv2Attack.Max = (5D);
            this.kEnv2Attack.Min = (0D);
            this.kEnv2Attack.Name = ("kEnv2Attack");
            this.kEnv2Attack.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv2Attack.SweepAngle = (270);
            this.kEnv2Attack.TabIndex = (29);
            this.kEnv2Attack.Thickness = (2);
            this.kEnv2Attack.Value = (0D);
            // 
            // kGlide
            // 
            this.kGlide._v = (50D);
            this.kGlide.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kGlide.BackgroundImage")));
            this.kGlide.Default = (50D);
            this.kGlide.Description = ("Glide");
            this.kGlide.Divisions = (10);
            this.kGlide.ForeColor = (global::System.Drawing.Color.White);
            this.kGlide.HideLabels = (false);
            this.kGlide.HideOutine = (true);
            this.kGlide.HideTicks = (true);
            this.kGlide.LabelMarker0 = ("0");
            this.kGlide.LabelMarker10 = ("10");
            this.kGlide.LabelMarker5 = ("");
            this.kGlide.LabelText = ("GLIDE");
            this.kGlide.LimitToInteger = (false);
            this.kGlide.Location = (new global::System.Drawing.Point(436, 242));
            this.kGlide.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kGlide.Max = (500D);
            this.kGlide.Min = (0D);
            this.kGlide.Name = ("kGlide");
            this.kGlide.Size = (new global::System.Drawing.Size(77, 77));
            this.kGlide.SweepAngle = (270);
            this.kGlide.TabIndex = (33);
            this.kGlide.Thickness = (2);
            this.kGlide.Value = (50D);
            // 
            // kNoiseMix
            // 
            this.kNoiseMix._v = (0D);
            this.kNoiseMix.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kNoiseMix.BackgroundImage")));
            this.kNoiseMix.Default = (0D);
            this.kNoiseMix.Description = ("Mixer Noise");
            this.kNoiseMix.Divisions = (10);
            this.kNoiseMix.ForeColor = (global::System.Drawing.Color.White);
            this.kNoiseMix.HideLabels = (false);
            this.kNoiseMix.HideOutine = (false);
            this.kNoiseMix.HideTicks = (true);
            this.kNoiseMix.LabelMarker0 = ("0");
            this.kNoiseMix.LabelMarker10 = ("10");
            this.kNoiseMix.LabelMarker5 = ("");
            this.kNoiseMix.LabelText = ("NOISE");
            this.kNoiseMix.LimitToInteger = (false);
            this.kNoiseMix.Location = (new global::System.Drawing.Point(341, 352));
            this.kNoiseMix.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kNoiseMix.Max = (1D);
            this.kNoiseMix.Min = (0D);
            this.kNoiseMix.Name = ("kNoiseMix");
            this.kNoiseMix.Size = (new global::System.Drawing.Size(77, 77));
            this.kNoiseMix.SweepAngle = (270);
            this.kNoiseMix.TabIndex = (34);
            this.kNoiseMix.Thickness = (2);
            this.kNoiseMix.Value = (0D);
            // 
            // panel7
            // 
            this.panel7.CornerRadius = (10);
            this.panel7.ID = ("LFO");
            this.panel7.LabelText = ("");
            this.panel7.LineWidth = (2);
            this.panel7.Location = (new global::System.Drawing.Point(6, 333));
            this.panel7.Name = ("panel7");
            this.panel7.Selected = (false);
            this.panel7.Size = (new global::System.Drawing.Size(322, 105));
            this.panel7.TabIndex = (35);
            // 
            // kLfo1Shape
            // 
            this.kLfo1Shape._v = (0D);
            this.kLfo1Shape.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kLfo1Shape.BackgroundImage")));
            this.kLfo1Shape.Default = (0D);
            this.kLfo1Shape.Description = ("LFO1 Shape");
            this.kLfo1Shape.Divisions = (5);
            this.kLfo1Shape.ForeColor = (global::System.Drawing.Color.White);
            this.kLfo1Shape.HideLabels = (true);
            this.kLfo1Shape.HideOutine = (false);
            this.kLfo1Shape.HideTicks = (true);
            this.kLfo1Shape.LabelMarker0 = ("0");
            this.kLfo1Shape.LabelMarker10 = ("10");
            this.kLfo1Shape.LabelMarker5 = ("5");
            this.kLfo1Shape.LabelText = ("SHAPE");
            this.kLfo1Shape.LimitToInteger = (true);
            this.kLfo1Shape.Location = (new global::System.Drawing.Point(86, 354));
            this.kLfo1Shape.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kLfo1Shape.Max = (5D);
            this.kLfo1Shape.Min = (0D);
            this.kLfo1Shape.Name = ("kLfo1Shape");
            this.kLfo1Shape.Size = (new global::System.Drawing.Size(77, 77));
            this.kLfo1Shape.SweepAngle = (160);
            this.kLfo1Shape.TabIndex = (37);
            this.kLfo1Shape.Thickness = (2);
            this.kLfo1Shape.Value = (0D);
            // 
            // kLfo1Rate
            // 
            this.kLfo1Rate._v = (0D);
            this.kLfo1Rate.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kLfo1Rate.BackgroundImage")));
            this.kLfo1Rate.Default = (0D);
            this.kLfo1Rate.Description = ("LFO1 Rate");
            this.kLfo1Rate.Divisions = (10);
            this.kLfo1Rate.ForeColor = (global::System.Drawing.Color.White);
            this.kLfo1Rate.HideLabels = (false);
            this.kLfo1Rate.HideOutine = (false);
            this.kLfo1Rate.HideTicks = (true);
            this.kLfo1Rate.LabelMarker0 = ("0");
            this.kLfo1Rate.LabelMarker10 = ("10");
            this.kLfo1Rate.LabelMarker5 = ("");
            this.kLfo1Rate.LabelText = ("RATE");
            this.kLfo1Rate.LimitToInteger = (false);
            this.kLfo1Rate.Location = (new global::System.Drawing.Point(12, 354));
            this.kLfo1Rate.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kLfo1Rate.Max = (1D);
            this.kLfo1Rate.Min = (0D);
            this.kLfo1Rate.Name = ("kLfo1Rate");
            this.kLfo1Rate.Size = (new global::System.Drawing.Size(77, 77));
            this.kLfo1Rate.SweepAngle = (270);
            this.kLfo1Rate.TabIndex = (36);
            this.kLfo1Rate.Thickness = (2);
            this.kLfo1Rate.Value = (0D);
            // 
            // kLfo2Shape
            // 
            this.kLfo2Shape._v = (0D);
            this.kLfo2Shape.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kLfo2Shape.BackgroundImage")));
            this.kLfo2Shape.Default = (0D);
            this.kLfo2Shape.Description = ("LFO2 Shape");
            this.kLfo2Shape.Divisions = (5);
            this.kLfo2Shape.ForeColor = (global::System.Drawing.Color.White);
            this.kLfo2Shape.HideLabels = (true);
            this.kLfo2Shape.HideOutine = (false);
            this.kLfo2Shape.HideTicks = (true);
            this.kLfo2Shape.LabelMarker0 = ("0");
            this.kLfo2Shape.LabelMarker10 = ("10");
            this.kLfo2Shape.LabelMarker5 = ("5");
            this.kLfo2Shape.LabelText = ("SHAPE");
            this.kLfo2Shape.LimitToInteger = (true);
            this.kLfo2Shape.Location = (new global::System.Drawing.Point(249, 354));
            this.kLfo2Shape.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kLfo2Shape.Max = (5D);
            this.kLfo2Shape.Min = (0D);
            this.kLfo2Shape.Name = ("kLfo2Shape");
            this.kLfo2Shape.Size = (new global::System.Drawing.Size(77, 77));
            this.kLfo2Shape.SweepAngle = (160);
            this.kLfo2Shape.TabIndex = (40);
            this.kLfo2Shape.Thickness = (2);
            this.kLfo2Shape.Value = (0D);
            // 
            // kLfo2Rate
            // 
            this.kLfo2Rate._v = (0D);
            this.kLfo2Rate.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kLfo2Rate.BackgroundImage")));
            this.kLfo2Rate.Default = (0D);
            this.kLfo2Rate.Description = ("LFO2 Rate");
            this.kLfo2Rate.Divisions = (10);
            this.kLfo2Rate.ForeColor = (global::System.Drawing.Color.White);
            this.kLfo2Rate.HideLabels = (false);
            this.kLfo2Rate.HideOutine = (false);
            this.kLfo2Rate.HideTicks = (true);
            this.kLfo2Rate.LabelMarker0 = ("0");
            this.kLfo2Rate.LabelMarker10 = ("10");
            this.kLfo2Rate.LabelMarker5 = ("");
            this.kLfo2Rate.LabelText = ("RATE");
            this.kLfo2Rate.LimitToInteger = (false);
            this.kLfo2Rate.Location = (new global::System.Drawing.Point(175, 354));
            this.kLfo2Rate.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kLfo2Rate.Max = (1D);
            this.kLfo2Rate.Min = (0D);
            this.kLfo2Rate.Name = ("kLfo2Rate");
            this.kLfo2Rate.Size = (new global::System.Drawing.Size(77, 77));
            this.kLfo2Rate.SweepAngle = (270);
            this.kLfo2Rate.TabIndex = (39);
            this.kLfo2Rate.Thickness = (2);
            this.kLfo2Rate.Value = (0D);
            // 
            // kEnv3Release
            // 
            this.kEnv3Release._v = (0D);
            this.kEnv3Release.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv3Release.BackgroundImage")));
            this.kEnv3Release.Default = (0D);
            this.kEnv3Release.Description = ("Envelope 3 - Release");
            this.kEnv3Release.Divisions = (10);
            this.kEnv3Release.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv3Release.HideLabels = (false);
            this.kEnv3Release.HideOutine = (true);
            this.kEnv3Release.HideTicks = (true);
            this.kEnv3Release.LabelMarker0 = ("0");
            this.kEnv3Release.LabelMarker10 = ("10");
            this.kEnv3Release.LabelMarker5 = ("");
            this.kEnv3Release.LabelText = ("RELEASE");
            this.kEnv3Release.LimitToInteger = (false);
            this.kEnv3Release.Location = (new global::System.Drawing.Point(752, 352));
            this.kEnv3Release.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv3Release.Max = (5D);
            this.kEnv3Release.Min = (0D);
            this.kEnv3Release.Name = ("kEnv3Release");
            this.kEnv3Release.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv3Release.SweepAngle = (270);
            this.kEnv3Release.TabIndex = (45);
            this.kEnv3Release.Thickness = (2);
            this.kEnv3Release.Value = (0D);
            // 
            // kEnv3Sustain
            // 
            this.kEnv3Sustain._v = (0D);
            this.kEnv3Sustain.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv3Sustain.BackgroundImage")));
            this.kEnv3Sustain.Default = (0D);
            this.kEnv3Sustain.Description = ("Envelope 3 - Sustain");
            this.kEnv3Sustain.Divisions = (10);
            this.kEnv3Sustain.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv3Sustain.HideLabels = (false);
            this.kEnv3Sustain.HideOutine = (true);
            this.kEnv3Sustain.HideTicks = (true);
            this.kEnv3Sustain.LabelMarker0 = ("0");
            this.kEnv3Sustain.LabelMarker10 = ("10");
            this.kEnv3Sustain.LabelMarker5 = ("");
            this.kEnv3Sustain.LabelText = ("SUSTAIN");
            this.kEnv3Sustain.LimitToInteger = (false);
            this.kEnv3Sustain.Location = (new global::System.Drawing.Point(678, 352));
            this.kEnv3Sustain.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv3Sustain.Max = (1D);
            this.kEnv3Sustain.Min = (0D);
            this.kEnv3Sustain.Name = ("kEnv3Sustain");
            this.kEnv3Sustain.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv3Sustain.SweepAngle = (270);
            this.kEnv3Sustain.TabIndex = (44);
            this.kEnv3Sustain.Thickness = (2);
            this.kEnv3Sustain.Value = (0D);
            // 
            // kEnv3Decay
            // 
            this.kEnv3Decay._v = (0D);
            this.kEnv3Decay.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv3Decay.BackgroundImage")));
            this.kEnv3Decay.Default = (0D);
            this.kEnv3Decay.Description = ("Envelope 3 - Decay");
            this.kEnv3Decay.Divisions = (10);
            this.kEnv3Decay.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv3Decay.HideLabels = (false);
            this.kEnv3Decay.HideOutine = (true);
            this.kEnv3Decay.HideTicks = (true);
            this.kEnv3Decay.LabelMarker0 = ("0");
            this.kEnv3Decay.LabelMarker10 = ("10");
            this.kEnv3Decay.LabelMarker5 = ("");
            this.kEnv3Decay.LabelText = ("DECAY");
            this.kEnv3Decay.LimitToInteger = (false);
            this.kEnv3Decay.Location = (new global::System.Drawing.Point(604, 352));
            this.kEnv3Decay.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv3Decay.Max = (5D);
            this.kEnv3Decay.Min = (0D);
            this.kEnv3Decay.Name = ("kEnv3Decay");
            this.kEnv3Decay.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv3Decay.SweepAngle = (270);
            this.kEnv3Decay.TabIndex = (43);
            this.kEnv3Decay.Thickness = (2);
            this.kEnv3Decay.Value = (0D);
            // 
            // kEnv3Attack
            // 
            this.kEnv3Attack._v = (0D);
            this.kEnv3Attack.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv3Attack.BackgroundImage")));
            this.kEnv3Attack.Default = (0D);
            this.kEnv3Attack.Description = ("Envelope 3 - Attack");
            this.kEnv3Attack.Divisions = (10);
            this.kEnv3Attack.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv3Attack.HideLabels = (false);
            this.kEnv3Attack.HideOutine = (true);
            this.kEnv3Attack.HideTicks = (true);
            this.kEnv3Attack.LabelMarker0 = ("0");
            this.kEnv3Attack.LabelMarker10 = ("10");
            this.kEnv3Attack.LabelMarker5 = ("");
            this.kEnv3Attack.LabelText = ("ATTACK");
            this.kEnv3Attack.LimitToInteger = (false);
            this.kEnv3Attack.Location = (new global::System.Drawing.Point(530, 352));
            this.kEnv3Attack.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv3Attack.Max = (5D);
            this.kEnv3Attack.Min = (0D);
            this.kEnv3Attack.Name = ("kEnv3Attack");
            this.kEnv3Attack.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv3Attack.SweepAngle = (270);
            this.kEnv3Attack.TabIndex = (42);
            this.kEnv3Attack.Thickness = (2);
            this.kEnv3Attack.Value = (0D);
            // 
            // panel9
            // 
            this.panel9.CornerRadius = (10);
            this.panel9.ID = ("");
            this.panel9.LabelText = ("ENV 3 - to patchbay");
            this.panel9.LineWidth = (2);
            this.panel9.Location = (new global::System.Drawing.Point(526, 334));
            this.panel9.Name = ("panel9");
            this.panel9.Selected = (false);
            this.panel9.Size = (new global::System.Drawing.Size(307, 105));
            this.panel9.TabIndex = (41);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((global::System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = (new global::System.Drawing.Point(12, 477));
            this.pictureBox1.Name = ("pictureBox1");
            this.pictureBox1.Size = (new global::System.Drawing.Size(103, 50));
            this.pictureBox1.TabIndex = (46);
            this.pictureBox1.TabStop = (false);
            // 
            // lblFilterType
            // 
            this.lblFilterType.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top) | (global::System.Windows.Forms.AnchorStyles.Left)) | (global::System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterType.AutoSize = (true);
            this.lblFilterType.ForeColor = (global::System.Drawing.Color.White);
            this.lblFilterType.Location = (new global::System.Drawing.Point(553, 102));
            this.lblFilterType.Name = ("lblFilterType");
            this.lblFilterType.Size = (new global::System.Drawing.Size(156, 15));
            this.lblFilterType.TabIndex = (50);
            this.lblFilterType.Text = ("Low Pass Butterworth 2 pole");
            this.lblFilterType.TextAlign = (global::System.Drawing.ContentAlignment.TopCenter);
            // 
            // cmdViewWave
            // 
            this.cmdViewWave.Location = (new global::System.Drawing.Point(121, 488));
            this.cmdViewWave.Name = ("cmdViewWave");
            this.cmdViewWave.Size = (new global::System.Drawing.Size(84, 28));
            this.cmdViewWave.TabIndex = (51);
            this.cmdViewWave.Text = ("View Wave");
            this.cmdViewWave.UseVisualStyleBackColor = (true);
            // 
            // cmdInit
            // 
            this.cmdInit.Location = (new global::System.Drawing.Point(211, 488));
            this.cmdInit.Name = ("cmdInit");
            this.cmdInit.Size = (new global::System.Drawing.Size(84, 28));
            this.cmdInit.TabIndex = (52);
            this.cmdInit.Text = ("Init Patch");
            this.cmdInit.UseVisualStyleBackColor = (true);
            // 
            // lblMidiChannel
            // 
            this.lblMidiChannel.AutoSize = (true);
            this.lblMidiChannel.ForeColor = (global::System.Drawing.Color.White);
            this.lblMidiChannel.Location = (new global::System.Drawing.Point(428, 343));
            this.lblMidiChannel.Name = ("lblMidiChannel");
            this.lblMidiChannel.Size = (new global::System.Drawing.Size(34, 15));
            this.lblMidiChannel.TabIndex = (53);
            this.lblMidiChannel.Text = ("Midi:");
            // 
            // label2
            // 
            this.label2.AutoSize = (true);
            this.label2.ForeColor = (global::System.Drawing.Color.White);
            this.label2.Location = (new global::System.Drawing.Point(444, 381));
            this.label2.Name = ("label2");
            this.label2.Size = (new global::System.Drawing.Size(65, 15));
            this.label2.TabIndex = (54);
            this.label2.Text = ("POLY GATE");
            // 
            // cboMidiChannel
            // 
            this.cboMidiChannel.BackColor = (global::System.Drawing.Color.DarkGreen);
            this.cboMidiChannel.DropDownStyle = (global::System.Windows.Forms.ComboBoxStyle.DropDownList);
            this.cboMidiChannel.FlatStyle = (global::System.Windows.Forms.FlatStyle.Popup);
            this.cboMidiChannel.Font = (new global::System.Drawing.Font("Arial Narrow", 9.75F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point));
            this.cboMidiChannel.ForeColor = (global::System.Drawing.Color.Lime);
            this.cboMidiChannel.FormattingEnabled = (true);
            this.cboMidiChannel.Items.AddRange(new global::System.Object[] { "All", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" });
            this.cboMidiChannel.Location = (new global::System.Drawing.Point(463, 339));
            this.cboMidiChannel.Name = ("cboMidiChannel");
            this.cboMidiChannel.Size = (new global::System.Drawing.Size(59, 24));
            this.cboMidiChannel.TabIndex = (55);
            // 
            // ledGate1
            // 
            this.ledGate1.Clickable = (false);
            this.ledGate1.ID = ("");
            this.ledGate1.LedColor = (global::System.Drawing.Color.Lime);
            this.ledGate1.LedShape = (global::UI.Controls.Led.Shape.Round);
            this.ledGate1.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledGate1.Location = (new global::System.Drawing.Point(433, 397));
            this.ledGate1.Name = ("ledGate1");
            this.ledGate1.Size = (new global::System.Drawing.Size(15, 15));
            this.ledGate1.TabIndex = (56);
            this.ledGate1.ToolTip = (null);
            // 
            // ledLfo1
            // 
            this.ledLfo1.Clickable = (false);
            this.ledLfo1.ID = ("");
            this.ledLfo1.LedColor = (global::System.Drawing.Color.Lime);
            this.ledLfo1.LedShape = (global::UI.Controls.Led.Shape.Round);
            this.ledLfo1.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledLfo1.Location = (new global::System.Drawing.Point(69, 350));
            this.ledLfo1.Name = ("ledLfo1");
            this.ledLfo1.Size = (new global::System.Drawing.Size(15, 15));
            this.ledLfo1.TabIndex = (57);
            this.ledLfo1.ToolTip = (null);
            // 
            // ledLfo2
            // 
            this.ledLfo2.Clickable = (false);
            this.ledLfo2.ID = ("");
            this.ledLfo2.LedColor = (global::System.Drawing.Color.Lime);
            this.ledLfo2.LedShape = (global::UI.Controls.Led.Shape.Round);
            this.ledLfo2.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledLfo2.Location = (new global::System.Drawing.Point(231, 350));
            this.ledLfo2.Name = ("ledLfo2");
            this.ledLfo2.Size = (new global::System.Drawing.Size(15, 15));
            this.ledLfo2.TabIndex = (58);
            this.ledLfo2.ToolTip = (null);
            // 
            // cmdControllers
            // 
            this.cmdControllers.Location = (new global::System.Drawing.Point(301, 488));
            this.cmdControllers.Name = ("cmdControllers");
            this.cmdControllers.Size = (new global::System.Drawing.Size(84, 28));
            this.cmdControllers.TabIndex = (59);
            this.cmdControllers.Text = ("Controllers");
            this.cmdControllers.UseVisualStyleBackColor = (true);
            // 
            // panel10
            // 
            this.panel10.CornerRadius = (10);
            this.panel10.ID = ("");
            this.panel10.LabelText = ("EFFECTS");
            this.panel10.LineWidth = (2);
            this.panel10.Location = (new global::System.Drawing.Point(839, 3));
            this.panel10.Name = ("panel10");
            this.panel10.Selected = (false);
            this.panel10.Size = (new global::System.Drawing.Size(322, 115));
            this.panel10.TabIndex = (60);
            // 
            // kEffectParam1
            // 
            this.kEffectParam1._v = (0D);
            this.kEffectParam1.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEffectParam1.BackgroundImage")));
            this.kEffectParam1.Default = (0D);
            this.kEffectParam1.Description = ("Effects - Knob1");
            this.kEffectParam1.Divisions = (10);
            this.kEffectParam1.ForeColor = (global::System.Drawing.Color.White);
            this.kEffectParam1.HideLabels = (false);
            this.kEffectParam1.HideOutine = (true);
            this.kEffectParam1.HideTicks = (true);
            this.kEffectParam1.LabelMarker0 = ("0");
            this.kEffectParam1.LabelMarker10 = ("10");
            this.kEffectParam1.LabelMarker5 = ("");
            this.kEffectParam1.LabelText = ("GAIN");
            this.kEffectParam1.LimitToInteger = (false);
            this.kEffectParam1.Location = (new global::System.Drawing.Point(920, 20));
            this.kEffectParam1.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEffectParam1.Max = (1D);
            this.kEffectParam1.Min = (0D);
            this.kEffectParam1.Name = ("kEffectParam1");
            this.kEffectParam1.Size = (new global::System.Drawing.Size(77, 77));
            this.kEffectParam1.SweepAngle = (270);
            this.kEffectParam1.TabIndex = (62);
            this.kEffectParam1.Thickness = (2);
            this.kEffectParam1.Value = (0D);
            // 
            // kEffectType
            // 
            this.kEffectType._v = (0D);
            this.kEffectType.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEffectType.BackgroundImage")));
            this.kEffectType.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.kEffectType.Default = (0D);
            this.kEffectType.Description = ("Effects Type");
            this.kEffectType.Divisions = (6);
            this.kEffectType.ForeColor = (global::System.Drawing.Color.White);
            this.kEffectType.HideLabels = (true);
            this.kEffectType.HideOutine = (false);
            this.kEffectType.HideTicks = (true);
            this.kEffectType.LabelMarker0 = ("0");
            this.kEffectType.LabelMarker10 = ("10");
            this.kEffectType.LabelMarker5 = ("");
            this.kEffectType.LabelText = ("TYPE");
            this.kEffectType.LimitToInteger = (true);
            this.kEffectType.Location = (new global::System.Drawing.Point(846, 20));
            this.kEffectType.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEffectType.Max = (5D);
            this.kEffectType.Min = (0D);
            this.kEffectType.Name = ("kEffectType");
            this.kEffectType.Size = (new global::System.Drawing.Size(77, 77));
            this.kEffectType.SweepAngle = (180);
            this.kEffectType.TabIndex = (61);
            this.kEffectType.Thickness = (2);
            this.kEffectType.Value = (0D);
            // 
            // kEffectMix
            // 
            this.kEffectMix._v = (-1D);
            this.kEffectMix.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEffectMix.BackgroundImage")));
            this.kEffectMix.Default = (0D);
            this.kEffectMix.Description = ("Effects - Mix");
            this.kEffectMix.Divisions = (10);
            this.kEffectMix.ForeColor = (global::System.Drawing.Color.White);
            this.kEffectMix.HideLabels = (false);
            this.kEffectMix.HideOutine = (true);
            this.kEffectMix.HideTicks = (true);
            this.kEffectMix.LabelMarker0 = ("-1");
            this.kEffectMix.LabelMarker10 = ("+1");
            this.kEffectMix.LabelMarker5 = ("0");
            this.kEffectMix.LabelText = ("MIX");
            this.kEffectMix.LimitToInteger = (false);
            this.kEffectMix.Location = (new global::System.Drawing.Point(1076, 20));
            this.kEffectMix.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEffectMix.Max = (1D);
            this.kEffectMix.Min = (-1D);
            this.kEffectMix.Name = ("kEffectMix");
            this.kEffectMix.Size = (new global::System.Drawing.Size(77, 77));
            this.kEffectMix.SweepAngle = (270);
            this.kEffectMix.TabIndex = (67);
            this.kEffectMix.Thickness = (2);
            this.kEffectMix.Value = (-1D);
            // 
            // kEffectParam2
            // 
            this.kEffectParam2._v = (0D);
            this.kEffectParam2.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEffectParam2.BackgroundImage")));
            this.kEffectParam2.Default = (0D);
            this.kEffectParam2.Description = ("Effects - Knob2");
            this.kEffectParam2.Divisions = (10);
            this.kEffectParam2.ForeColor = (global::System.Drawing.Color.White);
            this.kEffectParam2.HideLabels = (false);
            this.kEffectParam2.HideOutine = (true);
            this.kEffectParam2.HideTicks = (true);
            this.kEffectParam2.LabelMarker0 = ("0");
            this.kEffectParam2.LabelMarker10 = ("10");
            this.kEffectParam2.LabelMarker5 = ("");
            this.kEffectParam2.LabelText = ("FREQUENCY");
            this.kEffectParam2.LimitToInteger = (false);
            this.kEffectParam2.Location = (new global::System.Drawing.Point(1002, 20));
            this.kEffectParam2.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEffectParam2.Max = (1D);
            this.kEffectParam2.Min = (0D);
            this.kEffectParam2.Name = ("kEffectParam2");
            this.kEffectParam2.Size = (new global::System.Drawing.Size(77, 77));
            this.kEffectParam2.SweepAngle = (270);
            this.kEffectParam2.TabIndex = (66);
            this.kEffectParam2.Thickness = (2);
            this.kEffectParam2.Value = (0D);
            // 
            // lblEffectType
            // 
            this.lblEffectType.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top) | (global::System.Windows.Forms.AnchorStyles.Left)) | (global::System.Windows.Forms.AnchorStyles.Right)));
            this.lblEffectType.AutoSize = (true);
            this.lblEffectType.ForeColor = (global::System.Drawing.Color.White);
            this.lblEffectType.Location = (new global::System.Drawing.Point(870, 100));
            this.lblEffectType.Name = ("lblEffectType");
            this.lblEffectType.Size = (new global::System.Drawing.Size(43, 15));
            this.lblEffectType.TabIndex = (68);
            this.lblEffectType.Text = ("Reverb");
            this.lblEffectType.TextAlign = (global::System.Drawing.ContentAlignment.TopCenter);
            // 
            // panel11
            // 
            this.panel11.CornerRadius = (10);
            this.panel11.ID = ("BitCrush");
            this.panel11.LabelText = ("BIT-CRUSH");
            this.panel11.LineWidth = (2);
            this.panel11.Location = (new global::System.Drawing.Point(430, 3));
            this.panel11.Name = ("panel11");
            this.panel11.Selected = (false);
            this.panel11.Size = (new global::System.Drawing.Size(92, 215));
            this.panel11.TabIndex = (69);
            // 
            // kBitCrushSampleRate
            // 
            this.kBitCrushSampleRate._v = (0D);
            this.kBitCrushSampleRate.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kBitCrushSampleRate.BackgroundImage")));
            this.kBitCrushSampleRate.Default = (0D);
            this.kBitCrushSampleRate.Description = ("BitCrusher Sample Rate");
            this.kBitCrushSampleRate.Divisions = (10);
            this.kBitCrushSampleRate.ForeColor = (global::System.Drawing.Color.White);
            this.kBitCrushSampleRate.HideLabels = (false);
            this.kBitCrushSampleRate.HideOutine = (false);
            this.kBitCrushSampleRate.HideTicks = (true);
            this.kBitCrushSampleRate.LabelMarker0 = ("0");
            this.kBitCrushSampleRate.LabelMarker10 = ("10");
            this.kBitCrushSampleRate.LabelMarker5 = ("");
            this.kBitCrushSampleRate.LabelText = ("SAMP RATE");
            this.kBitCrushSampleRate.LimitToInteger = (false);
            this.kBitCrushSampleRate.Location = (new global::System.Drawing.Point(436, 19));
            this.kBitCrushSampleRate.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kBitCrushSampleRate.Max = (1D);
            this.kBitCrushSampleRate.Min = (0D);
            this.kBitCrushSampleRate.Name = ("kBitCrushSampleRate");
            this.kBitCrushSampleRate.Size = (new global::System.Drawing.Size(77, 77));
            this.kBitCrushSampleRate.SweepAngle = (270);
            this.kBitCrushSampleRate.TabIndex = (70);
            this.kBitCrushSampleRate.Thickness = (2);
            this.kBitCrushSampleRate.Value = (0D);
            // 
            // kBitCrushResolution
            // 
            this.kBitCrushResolution._v = (0D);
            this.kBitCrushResolution.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kBitCrushResolution.BackgroundImage")));
            this.kBitCrushResolution.Default = (0D);
            this.kBitCrushResolution.Description = ("BitCrusher Resolution");
            this.kBitCrushResolution.Divisions = (10);
            this.kBitCrushResolution.ForeColor = (global::System.Drawing.Color.White);
            this.kBitCrushResolution.HideLabels = (false);
            this.kBitCrushResolution.HideOutine = (false);
            this.kBitCrushResolution.HideTicks = (true);
            this.kBitCrushResolution.LabelMarker0 = ("0");
            this.kBitCrushResolution.LabelMarker10 = ("10");
            this.kBitCrushResolution.LabelMarker5 = ("");
            this.kBitCrushResolution.LabelText = ("RESOLUTION");
            this.kBitCrushResolution.LimitToInteger = (false);
            this.kBitCrushResolution.Location = (new global::System.Drawing.Point(436, 131));
            this.kBitCrushResolution.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kBitCrushResolution.Max = (1D);
            this.kBitCrushResolution.Min = (0D);
            this.kBitCrushResolution.Name = ("kBitCrushResolution");
            this.kBitCrushResolution.Size = (new global::System.Drawing.Size(77, 77));
            this.kBitCrushResolution.SweepAngle = (270);
            this.kBitCrushResolution.TabIndex = (71);
            this.kBitCrushResolution.Thickness = (2);
            this.kBitCrushResolution.Value = (0D);
            // 
            // ledVCO1
            // 
            this.ledVCO1.Clickable = (true);
            this.ledVCO1.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.ledVCO1.ID = ("VCO1");
            this.ledVCO1.LedColor = (global::System.Drawing.Color.Red);
            this.ledVCO1.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledVCO1.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledVCO1.Location = (new global::System.Drawing.Point(13, 13));
            this.ledVCO1.Name = ("ledVCO1");
            this.ledVCO1.Size = (new global::System.Drawing.Size(15, 10));
            this.ledVCO1.TabIndex = (72);
            this.ledVCO1.ToolTip = (null);
            // 
            // ledVCO2
            // 
            this.ledVCO2.Clickable = (true);
            this.ledVCO2.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.ledVCO2.ID = ("VCO2");
            this.ledVCO2.LedColor = (global::System.Drawing.Color.Red);
            this.ledVCO2.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledVCO2.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledVCO2.Location = (new global::System.Drawing.Point(13, 123));
            this.ledVCO2.Name = ("ledVCO2");
            this.ledVCO2.Size = (new global::System.Drawing.Size(15, 10));
            this.ledVCO2.TabIndex = (73);
            this.ledVCO2.ToolTip = (null);
            // 
            // ledVCO3
            // 
            this.ledVCO3.Clickable = (true);
            this.ledVCO3.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.ledVCO3.ID = ("VCO3");
            this.ledVCO3.LedColor = (global::System.Drawing.Color.Red);
            this.ledVCO3.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledVCO3.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledVCO3.Location = (new global::System.Drawing.Point(13, 234));
            this.ledVCO3.Name = ("ledVCO3");
            this.ledVCO3.Size = (new global::System.Drawing.Size(15, 10));
            this.ledVCO3.TabIndex = (74);
            this.ledVCO3.ToolTip = (null);
            // 
            // ledLFO
            // 
            this.ledLFO.Clickable = (true);
            this.ledLFO.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.ledLFO.ID = ("LFO");
            this.ledLFO.LedColor = (global::System.Drawing.Color.Red);
            this.ledLFO.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledLFO.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledLFO.Location = (new global::System.Drawing.Point(13, 343));
            this.ledLFO.Name = ("ledLFO");
            this.ledLFO.Size = (new global::System.Drawing.Size(15, 10));
            this.ledLFO.TabIndex = (75);
            this.ledLFO.ToolTip = (null);
            // 
            // ledMixer
            // 
            this.ledMixer.Clickable = (true);
            this.ledMixer.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.ledMixer.ID = ("MIXER");
            this.ledMixer.LedColor = (global::System.Drawing.Color.Red);
            this.ledMixer.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledMixer.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledMixer.Location = (new global::System.Drawing.Point(341, 13));
            this.ledMixer.Name = ("ledMixer");
            this.ledMixer.Size = (new global::System.Drawing.Size(15, 10));
            this.ledMixer.TabIndex = (76);
            this.ledMixer.ToolTip = (null);
            // 
            // ledVCF
            // 
            this.ledVCF.Clickable = (true);
            this.ledVCF.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.ledVCF.ID = ("VCF");
            this.ledVCF.LedColor = (global::System.Drawing.Color.Red);
            this.ledVCF.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledVCF.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledVCF.Location = (new global::System.Drawing.Point(533, 12));
            this.ledVCF.Name = ("ledVCF");
            this.ledVCF.Size = (new global::System.Drawing.Size(15, 10));
            this.ledVCF.TabIndex = (77);
            this.ledVCF.ToolTip = (null);
            // 
            // ledEnv1
            // 
            this.ledEnv1.Clickable = (true);
            this.ledEnv1.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.ledEnv1.ID = ("ENV1");
            this.ledEnv1.LedColor = (global::System.Drawing.Color.Red);
            this.ledEnv1.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledEnv1.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledEnv1.Location = (new global::System.Drawing.Point(533, 125));
            this.ledEnv1.Name = ("ledEnv1");
            this.ledEnv1.Size = (new global::System.Drawing.Size(15, 10));
            this.ledEnv1.TabIndex = (78);
            this.ledEnv1.ToolTip = (null);
            // 
            // ledBitCrush
            // 
            this.ledBitCrush.Clickable = (true);
            this.ledBitCrush.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.ledBitCrush.ID = ("BITCRUSH");
            this.ledBitCrush.LedColor = (global::System.Drawing.Color.Red);
            this.ledBitCrush.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledBitCrush.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledBitCrush.Location = (new global::System.Drawing.Point(440, 13));
            this.ledBitCrush.Name = ("ledBitCrush");
            this.ledBitCrush.Size = (new global::System.Drawing.Size(15, 10));
            this.ledBitCrush.TabIndex = (79);
            this.ledBitCrush.ToolTip = (null);
            // 
            // ledEnv2
            // 
            this.ledEnv2.Clickable = (true);
            this.ledEnv2.Cursor = (global::System.Windows.Forms.Cursors.Hand);
            this.ledEnv2.ID = ("ENV2");
            this.ledEnv2.LedColor = (global::System.Drawing.Color.Red);
            this.ledEnv2.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledEnv2.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledEnv2.Location = (new global::System.Drawing.Point(533, 234));
            this.ledEnv2.Name = ("ledEnv2");
            this.ledEnv2.Size = (new global::System.Drawing.Size(15, 10));
            this.ledEnv2.TabIndex = (80);
            this.ledEnv2.ToolTip = (null);
            // 
            // ledEnv3
            // 
            this.ledEnv3.Clickable = (true);
            this.ledEnv3.ID = ("ENV3");
            this.ledEnv3.LedColor = (global::System.Drawing.Color.Red);
            this.ledEnv3.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledEnv3.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledEnv3.Location = (new global::System.Drawing.Point(532, 346));
            this.ledEnv3.Name = ("ledEnv3");
            this.ledEnv3.Size = (new global::System.Drawing.Size(15, 10));
            this.ledEnv3.TabIndex = (81);
            this.ledEnv3.ToolTip = (null);
            // 
            // ledEffects
            // 
            this.ledEffects.Clickable = (true);
            this.ledEffects.ID = ("EFFECTS");
            this.ledEffects.LedColor = (global::System.Drawing.Color.Red);
            this.ledEffects.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledEffects.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledEffects.Location = (new global::System.Drawing.Point(847, 13));
            this.ledEffects.Name = ("ledEffects");
            this.ledEffects.Size = (new global::System.Drawing.Size(15, 10));
            this.ledEffects.TabIndex = (82);
            this.ledEffects.ToolTip = (null);
            // 
            // label1
            // 
            this.label1.AutoSize = (true);
            this.label1.ForeColor = (global::System.Drawing.Color.White);
            this.label1.Location = (new global::System.Drawing.Point(70, 331));
            this.label1.Name = ("label1");
            this.label1.Size = (new global::System.Drawing.Size(83, 15));
            this.label1.TabIndex = (83);
            this.label1.Text = ("LFO1 / CLOCK");
            // 
            // label3
            // 
            this.label3.AutoSize = (true);
            this.label3.ForeColor = (global::System.Drawing.Color.White);
            this.label3.Location = (new global::System.Drawing.Point(230, 331));
            this.label3.Name = ("label3");
            this.label3.Size = (new global::System.Drawing.Size(34, 15));
            this.label3.TabIndex = (84);
            this.label3.Text = ("LFO2");
            // 
            // panel8
            // 
            this.panel8.CornerRadius = (10);
            this.panel8.ID = ("");
            this.panel8.LabelText = ("MODULATION");
            this.panel8.LineWidth = (2);
            this.panel8.Location = (new global::System.Drawing.Point(841, 122));
            this.panel8.Name = ("panel8");
            this.panel8.Selected = (false);
            this.panel8.Size = (new global::System.Drawing.Size(322, 427));
            this.panel8.TabIndex = (85);
            // 
            // label4
            // 
            this.label4.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top) | (global::System.Windows.Forms.AnchorStyles.Left)) | (global::System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = (true);
            this.label4.ForeColor = (global::System.Drawing.Color.White);
            this.label4.Location = (new global::System.Drawing.Point(1071, 18));
            this.label4.Name = ("label4");
            this.label4.Size = (new global::System.Drawing.Size(29, 15));
            this.label4.TabIndex = (86);
            this.label4.Text = ("DRY");
            this.label4.TextAlign = (global::System.Drawing.ContentAlignment.TopCenter);
            // 
            // label5
            // 
            this.label5.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top) | (global::System.Windows.Forms.AnchorStyles.Left)) | (global::System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = (true);
            this.label5.ForeColor = (global::System.Drawing.Color.White);
            this.label5.Location = (new global::System.Drawing.Point(1136, 18));
            this.label5.Name = ("label5");
            this.label5.Size = (new global::System.Drawing.Size(20, 15));
            this.label5.TabIndex = (87);
            this.label5.Text = ("FX");
            this.label5.TextAlign = (global::System.Drawing.ContentAlignment.TopCenter);
            // 
            // triangle1
            // 
            this.triangle1.ForeColor = (global::System.Drawing.Color.White);
            this.triangle1.Label = ("VCA2");
            this.triangle1.Location = (new global::System.Drawing.Point(865, 138));
            this.triangle1.Name = ("triangle1");
            this.triangle1.Size = (new global::System.Drawing.Size(41, 54));
            this.triangle1.TabIndex = (88);
            this.triangle1.Thickness = (2);
            // 
            // kVca2
            // 
            this.kVca2._v = (0D);
            this.kVca2.BackColor = (global::System.Drawing.Color.Navy);
            this.kVca2.Default = (1D);
            this.kVca2.Description = ("VCA2 Amount");
            this.kVca2.Divisions = (10);
            this.kVca2.ForeColor = (global::System.Drawing.Color.White);
            this.kVca2.HideLabels = (true);
            this.kVca2.HideOutine = (false);
            this.kVca2.HideTicks = (true);
            this.kVca2.LabelMarker0 = ("0");
            this.kVca2.LabelMarker10 = ("");
            this.kVca2.LabelMarker5 = ("");
            this.kVca2.LabelText = ("");
            this.kVca2.LimitToInteger = (false);
            this.kVca2.Location = (new global::System.Drawing.Point(853, 180));
            this.kVca2.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVca2.Max = (1D);
            this.kVca2.Min = (0D);
            this.kVca2.Name = ("kVca2");
            this.kVca2.Size = (new global::System.Drawing.Size(63, 63));
            this.kVca2.SweepAngle = (270);
            this.kVca2.TabIndex = (91);
            this.kVca2.Thickness = (2);
            this.kVca2.Value = (0D);
            // 
            // triangle2
            // 
            this.triangle2.ForeColor = (global::System.Drawing.Color.White);
            this.triangle2.Label = ("VCA3");
            this.triangle2.Location = (new global::System.Drawing.Point(942, 138));
            this.triangle2.Name = ("triangle2");
            this.triangle2.Size = (new global::System.Drawing.Size(41, 54));
            this.triangle2.TabIndex = (92);
            this.triangle2.Thickness = (2);
            // 
            // kVca3
            // 
            this.kVca3._v = (0D);
            this.kVca3.BackColor = (global::System.Drawing.Color.Navy);
            this.kVca3.Default = (1D);
            this.kVca3.Description = ("VCA3 Amount");
            this.kVca3.Divisions = (10);
            this.kVca3.ForeColor = (global::System.Drawing.Color.White);
            this.kVca3.HideLabels = (true);
            this.kVca3.HideOutine = (false);
            this.kVca3.HideTicks = (true);
            this.kVca3.LabelMarker0 = ("0");
            this.kVca3.LabelMarker10 = ("");
            this.kVca3.LabelMarker5 = ("");
            this.kVca3.LabelText = ("");
            this.kVca3.LimitToInteger = (false);
            this.kVca3.Location = (new global::System.Drawing.Point(930, 180));
            this.kVca3.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVca3.Max = (1D);
            this.kVca3.Min = (0D);
            this.kVca3.Name = ("kVca3");
            this.kVca3.Size = (new global::System.Drawing.Size(63, 63));
            this.kVca3.SweepAngle = (270);
            this.kVca3.TabIndex = (93);
            this.kVca3.Thickness = (2);
            this.kVca3.Value = (0D);
            // 
            // triangle3
            // 
            this.triangle3.ForeColor = (global::System.Drawing.Color.White);
            this.triangle3.Label = ("VCA4");
            this.triangle3.Location = (new global::System.Drawing.Point(1022, 138));
            this.triangle3.Name = ("triangle3");
            this.triangle3.Size = (new global::System.Drawing.Size(41, 54));
            this.triangle3.TabIndex = (94);
            this.triangle3.Thickness = (2);
            // 
            // kVca4
            // 
            this.kVca4._v = (0D);
            this.kVca4.BackColor = (global::System.Drawing.Color.Navy);
            this.kVca4.Default = (1D);
            this.kVca4.Description = ("VCA4 Amount");
            this.kVca4.Divisions = (10);
            this.kVca4.ForeColor = (global::System.Drawing.Color.White);
            this.kVca4.HideLabels = (true);
            this.kVca4.HideOutine = (false);
            this.kVca4.HideTicks = (true);
            this.kVca4.LabelMarker0 = ("0");
            this.kVca4.LabelMarker10 = ("");
            this.kVca4.LabelMarker5 = ("");
            this.kVca4.LabelText = ("");
            this.kVca4.LimitToInteger = (false);
            this.kVca4.Location = (new global::System.Drawing.Point(1010, 180));
            this.kVca4.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVca4.Max = (1D);
            this.kVca4.Min = (0D);
            this.kVca4.Name = ("kVca4");
            this.kVca4.Size = (new global::System.Drawing.Size(63, 63));
            this.kVca4.SweepAngle = (270);
            this.kVca4.TabIndex = (95);
            this.kVca4.Thickness = (2);
            this.kVca4.Value = (0D);
            // 
            // rect1
            // 
            this.rect1.BackColor = (global::System.Drawing.Color.White);
            this.rect1.Color = (global::System.Drawing.Color.White);
            this.rect1.Location = (new global::System.Drawing.Point(884, 179));
            this.rect1.Name = ("rect1");
            this.rect1.Size = (new global::System.Drawing.Size(1, 15));
            this.rect1.TabIndex = (96);
            // 
            // rect2
            // 
            this.rect2.BackColor = (global::System.Drawing.Color.White);
            this.rect2.Color = (global::System.Drawing.Color.White);
            this.rect2.Location = (new global::System.Drawing.Point(961, 178));
            this.rect2.Name = ("rect2");
            this.rect2.Size = (new global::System.Drawing.Size(1, 15));
            this.rect2.TabIndex = (97);
            // 
            // rect3
            // 
            this.rect3.BackColor = (global::System.Drawing.Color.White);
            this.rect3.Color = (global::System.Drawing.Color.White);
            this.rect3.Location = (new global::System.Drawing.Point(1041, 180));
            this.rect3.Name = ("rect3");
            this.rect3.Size = (new global::System.Drawing.Size(1, 15));
            this.rect3.TabIndex = (98);
            // 
            // rect4
            // 
            this.rect4.BackColor = (global::System.Drawing.Color.White);
            this.rect4.Color = (global::System.Drawing.Color.White);
            this.rect4.Location = (new global::System.Drawing.Point(885, 223));
            this.rect4.Name = ("rect4");
            this.rect4.Size = (new global::System.Drawing.Size(1, 12));
            this.rect4.TabIndex = (99);
            // 
            // rect5
            // 
            this.rect5.BackColor = (global::System.Drawing.Color.White);
            this.rect5.Color = (global::System.Drawing.Color.White);
            this.rect5.Location = (new global::System.Drawing.Point(962, 223));
            this.rect5.Name = ("rect5");
            this.rect5.Size = (new global::System.Drawing.Size(1, 12));
            this.rect5.TabIndex = (100);
            // 
            // rect6
            // 
            this.rect6.BackColor = (global::System.Drawing.Color.White);
            this.rect6.Color = (global::System.Drawing.Color.White);
            this.rect6.Location = (new global::System.Drawing.Point(1042, 222));
            this.rect6.Name = ("rect6");
            this.rect6.Size = (new global::System.Drawing.Size(1, 12));
            this.rect6.TabIndex = (101);
            // 
            // rect7
            // 
            this.rect7.BackColor = (global::System.Drawing.Color.White);
            this.rect7.Color = (global::System.Drawing.Color.White);
            this.rect7.Location = (new global::System.Drawing.Point(855, 164));
            this.rect7.Name = ("rect7");
            this.rect7.Size = (new global::System.Drawing.Size(10, 1));
            this.rect7.TabIndex = (102);
            // 
            // rect8
            // 
            this.rect8.BackColor = (global::System.Drawing.Color.White);
            this.rect8.Color = (global::System.Drawing.Color.White);
            this.rect8.Location = (new global::System.Drawing.Point(931, 164));
            this.rect8.Name = ("rect8");
            this.rect8.Size = (new global::System.Drawing.Size(10, 1));
            this.rect8.TabIndex = (103);
            // 
            // rect9
            // 
            this.rect9.BackColor = (global::System.Drawing.Color.White);
            this.rect9.Color = (global::System.Drawing.Color.White);
            this.rect9.Location = (new global::System.Drawing.Point(1012, 164));
            this.rect9.Name = ("rect9");
            this.rect9.Size = (new global::System.Drawing.Size(10, 1));
            this.rect9.TabIndex = (104);
            // 
            // rect10
            // 
            this.rect10.BackColor = (global::System.Drawing.Color.White);
            this.rect10.Color = (global::System.Drawing.Color.White);
            this.rect10.Location = (new global::System.Drawing.Point(905, 165));
            this.rect10.Name = ("rect10");
            this.rect10.Size = (new global::System.Drawing.Size(10, 1));
            this.rect10.TabIndex = (105);
            // 
            // rect11
            // 
            this.rect11.BackColor = (global::System.Drawing.Color.White);
            this.rect11.Color = (global::System.Drawing.Color.White);
            this.rect11.Location = (new global::System.Drawing.Point(983, 165));
            this.rect11.Name = ("rect11");
            this.rect11.Size = (new global::System.Drawing.Size(10, 1));
            this.rect11.TabIndex = (106);
            // 
            // rect12
            // 
            this.rect12.BackColor = (global::System.Drawing.Color.White);
            this.rect12.Color = (global::System.Drawing.Color.White);
            this.rect12.Location = (new global::System.Drawing.Point(1063, 165));
            this.rect12.Name = ("rect12");
            this.rect12.Size = (new global::System.Drawing.Size(10, 1));
            this.rect12.TabIndex = (107);
            // 
            // label6
            // 
            this.label6.AutoSize = (true);
            this.label6.ForeColor = (global::System.Drawing.Color.White);
            this.label6.Location = (new global::System.Drawing.Point(849, 149));
            this.label6.Name = ("label6");
            this.label6.Size = (new global::System.Drawing.Size(13, 15));
            this.label6.TabIndex = (108);
            this.label6.Text = ("a");
            // 
            // label7
            // 
            this.label7.AutoSize = (true);
            this.label7.ForeColor = (global::System.Drawing.Color.White);
            this.label7.Location = (new global::System.Drawing.Point(871, 227));
            this.label7.Name = ("label7");
            this.label7.Size = (new global::System.Drawing.Size(14, 15));
            this.label7.TabIndex = (109);
            this.label7.Text = ("b");
            // 
            // label8
            // 
            this.label8.AutoSize = (true);
            this.label8.ForeColor = (global::System.Drawing.Color.White);
            this.label8.Location = (new global::System.Drawing.Point(908, 149));
            this.label8.Name = ("label8");
            this.label8.Size = (new global::System.Drawing.Size(13, 15));
            this.label8.TabIndex = (110);
            this.label8.Text = ("c");
            // 
            // label9
            // 
            this.label9.AutoSize = (true);
            this.label9.ForeColor = (global::System.Drawing.Color.White);
            this.label9.Location = (new global::System.Drawing.Point(985, 150));
            this.label9.Name = ("label9");
            this.label9.Size = (new global::System.Drawing.Size(11, 15));
            this.label9.TabIndex = (113);
            this.label9.Text = ("f");
            // 
            // label10
            // 
            this.label10.AutoSize = (true);
            this.label10.ForeColor = (global::System.Drawing.Color.White);
            this.label10.Location = (new global::System.Drawing.Point(948, 227));
            this.label10.Name = ("label10");
            this.label10.Size = (new global::System.Drawing.Size(13, 15));
            this.label10.TabIndex = (112);
            this.label10.Text = ("e");
            // 
            // label11
            // 
            this.label11.AutoSize = (true);
            this.label11.ForeColor = (global::System.Drawing.Color.White);
            this.label11.Location = (new global::System.Drawing.Point(925, 149));
            this.label11.Name = ("label11");
            this.label11.Size = (new global::System.Drawing.Size(14, 15));
            this.label11.TabIndex = (111);
            this.label11.Text = ("d");
            // 
            // label12
            // 
            this.label12.AutoSize = (true);
            this.label12.ForeColor = (global::System.Drawing.Color.White);
            this.label12.Location = (new global::System.Drawing.Point(1066, 150));
            this.label12.Name = ("label12");
            this.label12.Size = (new global::System.Drawing.Size(10, 15));
            this.label12.TabIndex = (116);
            this.label12.Text = ("i");
            // 
            // label13
            // 
            this.label13.AutoSize = (true);
            this.label13.ForeColor = (global::System.Drawing.Color.White);
            this.label13.Location = (new global::System.Drawing.Point(1028, 227));
            this.label13.Name = ("label13");
            this.label13.Size = (new global::System.Drawing.Size(14, 15));
            this.label13.TabIndex = (115);
            this.label13.Text = ("h");
            // 
            // label14
            // 
            this.label14.AutoSize = (true);
            this.label14.ForeColor = (global::System.Drawing.Color.White);
            this.label14.Location = (new global::System.Drawing.Point(1005, 148));
            this.label14.Name = ("label14");
            this.label14.Size = (new global::System.Drawing.Size(14, 15));
            this.label14.TabIndex = (114);
            this.label14.Text = ("g");
            // 
            // label15
            // 
            this.label15.AutoSize = (true);
            this.label15.ForeColor = (global::System.Drawing.Color.White);
            this.label15.Location = (new global::System.Drawing.Point(1145, 151));
            this.label15.Name = ("label15");
            this.label15.Size = (new global::System.Drawing.Size(10, 15));
            this.label15.TabIndex = (125);
            this.label15.Text = ("l");
            // 
            // label16
            // 
            this.label16.AutoSize = (true);
            this.label16.ForeColor = (global::System.Drawing.Color.White);
            this.label16.Location = (new global::System.Drawing.Point(1108, 228));
            this.label16.Name = ("label16");
            this.label16.Size = (new global::System.Drawing.Size(13, 15));
            this.label16.TabIndex = (124);
            this.label16.Text = ("k");
            // 
            // label17
            // 
            this.label17.AutoSize = (true);
            this.label17.ForeColor = (global::System.Drawing.Color.White);
            this.label17.Location = (new global::System.Drawing.Point(1087, 149));
            this.label17.Name = ("label17");
            this.label17.Size = (new global::System.Drawing.Size(10, 15));
            this.label17.TabIndex = (123);
            this.label17.Text = ("j");
            // 
            // rect13
            // 
            this.rect13.BackColor = (global::System.Drawing.Color.White);
            this.rect13.Color = (global::System.Drawing.Color.White);
            this.rect13.Location = (new global::System.Drawing.Point(1142, 166));
            this.rect13.Name = ("rect13");
            this.rect13.Size = (new global::System.Drawing.Size(10, 1));
            this.rect13.TabIndex = (122);
            // 
            // rect14
            // 
            this.rect14.BackColor = (global::System.Drawing.Color.White);
            this.rect14.Color = (global::System.Drawing.Color.White);
            this.rect14.Location = (new global::System.Drawing.Point(1091, 165));
            this.rect14.Name = ("rect14");
            this.rect14.Size = (new global::System.Drawing.Size(10, 1));
            this.rect14.TabIndex = (121);
            // 
            // rect15
            // 
            this.rect15.BackColor = (global::System.Drawing.Color.White);
            this.rect15.Color = (global::System.Drawing.Color.White);
            this.rect15.Location = (new global::System.Drawing.Point(1121, 223));
            this.rect15.Name = ("rect15");
            this.rect15.Size = (new global::System.Drawing.Size(1, 12));
            this.rect15.TabIndex = (120);
            // 
            // rect16
            // 
            this.rect16.BackColor = (global::System.Drawing.Color.White);
            this.rect16.Color = (global::System.Drawing.Color.White);
            this.rect16.Location = (new global::System.Drawing.Point(1120, 181));
            this.rect16.Name = ("rect16");
            this.rect16.Size = (new global::System.Drawing.Size(1, 15));
            this.rect16.TabIndex = (119);
            // 
            // triangle4
            // 
            this.triangle4.ForeColor = (global::System.Drawing.Color.White);
            this.triangle4.Label = ("VCA5");
            this.triangle4.Location = (new global::System.Drawing.Point(1101, 139));
            this.triangle4.Name = ("triangle4");
            this.triangle4.Size = (new global::System.Drawing.Size(41, 54));
            this.triangle4.TabIndex = (117);
            this.triangle4.Thickness = (2);
            // 
            // kVca5
            // 
            this.kVca5._v = (0D);
            this.kVca5.BackColor = (global::System.Drawing.Color.Navy);
            this.kVca5.Default = (1D);
            this.kVca5.Description = ("VCA5 Amount");
            this.kVca5.Divisions = (10);
            this.kVca5.ForeColor = (global::System.Drawing.Color.White);
            this.kVca5.HideLabels = (true);
            this.kVca5.HideOutine = (false);
            this.kVca5.HideTicks = (true);
            this.kVca5.LabelMarker0 = ("0");
            this.kVca5.LabelMarker10 = ("");
            this.kVca5.LabelMarker5 = ("");
            this.kVca5.LabelText = ("");
            this.kVca5.LimitToInteger = (false);
            this.kVca5.Location = (new global::System.Drawing.Point(1089, 181));
            this.kVca5.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kVca5.Max = (1D);
            this.kVca5.Min = (0D);
            this.kVca5.Name = ("kVca5");
            this.kVca5.Size = (new global::System.Drawing.Size(63, 63));
            this.kVca5.SweepAngle = (270);
            this.kVca5.TabIndex = (118);
            this.kVca5.Thickness = (2);
            this.kVca5.Value = (0D);
            // 
            // ledVcas
            // 
            this.ledVcas.Clickable = (true);
            this.ledVcas.ID = ("VCAS");
            this.ledVcas.LedColor = (global::System.Drawing.Color.Red);
            this.ledVcas.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledVcas.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledVcas.Location = (new global::System.Drawing.Point(847, 132));
            this.ledVcas.Name = ("ledVcas");
            this.ledVcas.Size = (new global::System.Drawing.Size(15, 10));
            this.ledVcas.TabIndex = (126);
            this.ledVcas.ToolTip = (null);
            // 
            // label18
            // 
            this.label18.AutoSize = (true);
            this.label18.ForeColor = (global::System.Drawing.Color.White);
            this.label18.Location = (new global::System.Drawing.Point(857, 259));
            this.label18.Name = ("label18");
            this.label18.Size = (new global::System.Drawing.Size(91, 15));
            this.label18.TabIndex = (127);
            this.label18.Text = ("MOD SOURCES:");
            // 
            // label19
            // 
            this.label19.AutoSize = (true);
            this.label19.ForeColor = (global::System.Drawing.Color.White);
            this.label19.Location = (new global::System.Drawing.Point(983, 259));
            this.label19.Name = ("label19");
            this.label19.Size = (new global::System.Drawing.Size(119, 15));
            this.label19.TabIndex = (128);
            this.label19.Text = ("MOD DESTINATIONS:");
            // 
            // label20
            // 
            this.label20.AutoSize = (true);
            this.label20.ForeColor = (global::System.Drawing.Color.White);
            this.label20.Location = (new global::System.Drawing.Point(870, 275));
            this.label20.Name = ("label20");
            this.label20.Size = (new global::System.Drawing.Size(37, 15));
            this.label20.TabIndex = (129);
            this.label20.Text = ("VCO1");
            // 
            // label21
            // 
            this.label21.AutoSize = (true);
            this.label21.ForeColor = (global::System.Drawing.Color.White);
            this.label21.Location = (new global::System.Drawing.Point(870, 290));
            this.label21.Name = ("label21");
            this.label21.Size = (new global::System.Drawing.Size(37, 15));
            this.label21.TabIndex = (130);
            this.label21.Text = ("VCO2");
            // 
            // label22
            // 
            this.label22.AutoSize = (true);
            this.label22.ForeColor = (global::System.Drawing.Color.White);
            this.label22.Location = (new global::System.Drawing.Point(870, 305));
            this.label22.Name = ("label22");
            this.label22.Size = (new global::System.Drawing.Size(37, 15));
            this.label22.TabIndex = (131);
            this.label22.Text = ("VCO3");
            // 
            // label23
            // 
            this.label23.AutoSize = (true);
            this.label23.ForeColor = (global::System.Drawing.Color.White);
            this.label23.Location = (new global::System.Drawing.Point(870, 320));
            this.label23.Name = ("label23");
            this.label23.Size = (new global::System.Drawing.Size(34, 15));
            this.label23.TabIndex = (132);
            this.label23.Text = ("LFO1");
            // 
            // label24
            // 
            this.label24.AutoSize = (true);
            this.label24.ForeColor = (global::System.Drawing.Color.White);
            this.label24.Location = (new global::System.Drawing.Point(870, 335));
            this.label24.Name = ("label24");
            this.label24.Size = (new global::System.Drawing.Size(34, 15));
            this.label24.TabIndex = (133);
            this.label24.Text = ("LFO2");
            // 
            // label25
            // 
            this.label25.AutoSize = (true);
            this.label25.ForeColor = (global::System.Drawing.Color.White);
            this.label25.Location = (new global::System.Drawing.Point(870, 350));
            this.label25.Name = ("label25");
            this.label25.Size = (new global::System.Drawing.Size(43, 15));
            this.label25.TabIndex = (134);
            this.label25.Text = ("ENV3+");
            // 
            // label26
            // 
            this.label26.AutoSize = (true);
            this.label26.ForeColor = (global::System.Drawing.Color.White);
            this.label26.Location = (new global::System.Drawing.Point(870, 365));
            this.label26.Name = ("label26");
            this.label26.Size = (new global::System.Drawing.Size(40, 15));
            this.label26.TabIndex = (135);
            this.label26.Text = ("ENV3-");
            // 
            // label27
            // 
            this.label27.AutoSize = (true);
            this.label27.ForeColor = (global::System.Drawing.Color.White);
            this.label27.Location = (new global::System.Drawing.Point(870, 472));
            this.label27.Name = ("label27");
            this.label27.Size = (new global::System.Drawing.Size(76, 15));
            this.label27.TabIndex = (136);
            this.label27.Text = ("MOD WHEEL");
            // 
            // label33
            // 
            this.label33.AutoSize = (true);
            this.label33.ForeColor = (global::System.Drawing.Color.White);
            this.label33.Location = (new global::System.Drawing.Point(999, 305));
            this.label33.Name = ("label33");
            this.label33.Size = (new global::System.Drawing.Size(73, 15));
            this.label33.TabIndex = (139);
            this.label33.Text = ("VCO1 - Sync");
            // 
            // label34
            // 
            this.label34.AutoSize = (true);
            this.label34.ForeColor = (global::System.Drawing.Color.White);
            this.label34.Location = (new global::System.Drawing.Point(999, 290));
            this.label34.Name = ("label34");
            this.label34.Size = (new global::System.Drawing.Size(66, 15));
            this.label34.TabIndex = (138);
            this.label34.Text = ("VCO1 - PW");
            // 
            // label35
            // 
            this.label35.AutoSize = (true);
            this.label35.ForeColor = (global::System.Drawing.Color.White);
            this.label35.Location = (new global::System.Drawing.Point(999, 275));
            this.label35.Name = ("label35");
            this.label35.Size = (new global::System.Drawing.Size(71, 15));
            this.label35.TabIndex = (137);
            this.label35.Text = ("VCO1 - Freq");
            // 
            // label28
            // 
            this.label28.AutoSize = (true);
            this.label28.ForeColor = (global::System.Drawing.Color.White);
            this.label28.Location = (new global::System.Drawing.Point(999, 351));
            this.label28.Name = ("label28");
            this.label28.Size = (new global::System.Drawing.Size(73, 15));
            this.label28.TabIndex = (142);
            this.label28.Text = ("VCO2 - Sync");
            // 
            // label29
            // 
            this.label29.AutoSize = (true);
            this.label29.ForeColor = (global::System.Drawing.Color.White);
            this.label29.Location = (new global::System.Drawing.Point(999, 336));
            this.label29.Name = ("label29");
            this.label29.Size = (new global::System.Drawing.Size(66, 15));
            this.label29.TabIndex = (141);
            this.label29.Text = ("VCO2 - PW");
            // 
            // label30
            // 
            this.label30.AutoSize = (true);
            this.label30.ForeColor = (global::System.Drawing.Color.White);
            this.label30.Location = (new global::System.Drawing.Point(999, 321));
            this.label30.Name = ("label30");
            this.label30.Size = (new global::System.Drawing.Size(71, 15));
            this.label30.TabIndex = (140);
            this.label30.Text = ("VCO2 - Freq");
            // 
            // label31
            // 
            this.label31.AutoSize = (true);
            this.label31.ForeColor = (global::System.Drawing.Color.White);
            this.label31.Location = (new global::System.Drawing.Point(999, 397));
            this.label31.Name = ("label31");
            this.label31.Size = (new global::System.Drawing.Size(73, 15));
            this.label31.TabIndex = (145);
            this.label31.Text = ("VCO3 - Sync");
            // 
            // label32
            // 
            this.label32.AutoSize = (true);
            this.label32.ForeColor = (global::System.Drawing.Color.White);
            this.label32.Location = (new global::System.Drawing.Point(999, 382));
            this.label32.Name = ("label32");
            this.label32.Size = (new global::System.Drawing.Size(66, 15));
            this.label32.TabIndex = (144);
            this.label32.Text = ("VCO3 - PW");
            // 
            // label36
            // 
            this.label36.AutoSize = (true);
            this.label36.ForeColor = (global::System.Drawing.Color.White);
            this.label36.Location = (new global::System.Drawing.Point(999, 367));
            this.label36.Name = ("label36");
            this.label36.Size = (new global::System.Drawing.Size(71, 15));
            this.label36.TabIndex = (143);
            this.label36.Text = ("VCO3 - Freq");
            // 
            // label37
            // 
            this.label37.AutoSize = (true);
            this.label37.ForeColor = (global::System.Drawing.Color.White);
            this.label37.Location = (new global::System.Drawing.Point(1078, 414));
            this.label37.Name = ("label37");
            this.label37.Size = (new global::System.Drawing.Size(54, 15));
            this.label37.TabIndex = (154);
            this.label37.Text = ("VCA4 - h");
            // 
            // label38
            // 
            this.label38.AutoSize = (true);
            this.label38.ForeColor = (global::System.Drawing.Color.White);
            this.label38.Location = (new global::System.Drawing.Point(1078, 399));
            this.label38.Name = ("label38");
            this.label38.Size = (new global::System.Drawing.Size(54, 15));
            this.label38.TabIndex = (153);
            this.label38.Text = ("VCA4 - g");
            // 
            // label39
            // 
            this.label39.AutoSize = (true);
            this.label39.ForeColor = (global::System.Drawing.Color.White);
            this.label39.Location = (new global::System.Drawing.Point(1078, 384));
            this.label39.Name = ("label39");
            this.label39.Size = (new global::System.Drawing.Size(53, 15));
            this.label39.TabIndex = (152);
            this.label39.Text = ("VCA3 - e");
            // 
            // label40
            // 
            this.label40.AutoSize = (true);
            this.label40.ForeColor = (global::System.Drawing.Color.White);
            this.label40.Location = (new global::System.Drawing.Point(1078, 368));
            this.label40.Name = ("label40");
            this.label40.Size = (new global::System.Drawing.Size(54, 15));
            this.label40.TabIndex = (151);
            this.label40.Text = ("VCA3 - d");
            // 
            // label41
            // 
            this.label41.AutoSize = (true);
            this.label41.ForeColor = (global::System.Drawing.Color.White);
            this.label41.Location = (new global::System.Drawing.Point(1078, 353));
            this.label41.Name = ("label41");
            this.label41.Size = (new global::System.Drawing.Size(54, 15));
            this.label41.TabIndex = (150);
            this.label41.Text = ("VCA2 - b");
            // 
            // label42
            // 
            this.label42.AutoSize = (true);
            this.label42.ForeColor = (global::System.Drawing.Color.White);
            this.label42.Location = (new global::System.Drawing.Point(1078, 338));
            this.label42.Name = ("label42");
            this.label42.Size = (new global::System.Drawing.Size(53, 15));
            this.label42.TabIndex = (149);
            this.label42.Text = ("VCA2 - a");
            // 
            // label43
            // 
            this.label43.AutoSize = (true);
            this.label43.ForeColor = (global::System.Drawing.Color.White);
            this.label43.Location = (new global::System.Drawing.Point(999, 475));
            this.label43.Name = ("label43");
            this.label43.Size = (new global::System.Drawing.Size(76, 15));
            this.label43.TabIndex = (148);
            this.label43.Text = ("VCA1 - Amp.");
            // 
            // label44
            // 
            this.label44.AutoSize = (true);
            this.label44.ForeColor = (global::System.Drawing.Color.White);
            this.label44.Location = (new global::System.Drawing.Point(999, 460));
            this.label44.Name = ("label44");
            this.label44.Size = (new global::System.Drawing.Size(57, 15));
            this.label44.TabIndex = (147);
            this.label44.Text = ("VCF - Res");
            // 
            // label45
            // 
            this.label45.AutoSize = (true);
            this.label45.ForeColor = (global::System.Drawing.Color.White);
            this.label45.Location = (new global::System.Drawing.Point(999, 413));
            this.label45.Name = ("label45");
            this.label45.Size = (new global::System.Drawing.Size(68, 15));
            this.label45.TabIndex = (146);
            this.label45.Text = ("LFO1 - Rate");
            // 
            // label46
            // 
            this.label46.AutoSize = (true);
            this.label46.ForeColor = (global::System.Drawing.Color.White);
            this.label46.Location = (new global::System.Drawing.Point(1078, 444));
            this.label46.Name = ("label46");
            this.label46.Size = (new global::System.Drawing.Size(53, 15));
            this.label46.TabIndex = (156);
            this.label46.Text = ("VCA5 - k");
            // 
            // label47
            // 
            this.label47.AutoSize = (true);
            this.label47.ForeColor = (global::System.Drawing.Color.White);
            this.label47.Location = (new global::System.Drawing.Point(1078, 429));
            this.label47.Name = ("label47");
            this.label47.Size = (new global::System.Drawing.Size(50, 15));
            this.label47.TabIndex = (155);
            this.label47.Text = ("VCA5 - j");
            // 
            // label48
            // 
            this.label48.AutoSize = (true);
            this.label48.ForeColor = (global::System.Drawing.Color.White);
            this.label48.Location = (new global::System.Drawing.Point(1078, 322));
            this.label48.Name = ("label48");
            this.label48.Size = (new global::System.Drawing.Size(82, 15));
            this.label48.TabIndex = (160);
            this.label48.Text = ("MIXER - Noise");
            // 
            // label49
            // 
            this.label49.AutoSize = (true);
            this.label49.ForeColor = (global::System.Drawing.Color.White);
            this.label49.Location = (new global::System.Drawing.Point(1078, 306));
            this.label49.Name = ("label49");
            this.label49.Size = (new global::System.Drawing.Size(77, 15));
            this.label49.TabIndex = (159);
            this.label49.Text = ("MIXER - Vco3");
            // 
            // label50
            // 
            this.label50.AutoSize = (true);
            this.label50.ForeColor = (global::System.Drawing.Color.White);
            this.label50.Location = (new global::System.Drawing.Point(1078, 291));
            this.label50.Name = ("label50");
            this.label50.Size = (new global::System.Drawing.Size(77, 15));
            this.label50.TabIndex = (158);
            this.label50.Text = ("MIXER - Vco2");
            // 
            // label51
            // 
            this.label51.AutoSize = (true);
            this.label51.ForeColor = (global::System.Drawing.Color.White);
            this.label51.Location = (new global::System.Drawing.Point(1078, 276));
            this.label51.Name = ("label51");
            this.label51.Size = (new global::System.Drawing.Size(77, 15));
            this.label51.TabIndex = (157);
            this.label51.Text = ("MIXER - Vco1");
            // 
            // label52
            // 
            this.label52.AutoSize = (true);
            this.label52.ForeColor = (global::System.Drawing.Color.White);
            this.label52.Location = (new global::System.Drawing.Point(999, 429));
            this.label52.Name = ("label52");
            this.label52.Size = (new global::System.Drawing.Size(68, 15));
            this.label52.TabIndex = (161);
            this.label52.Text = ("LFO2 - Rate");
            // 
            // label53
            // 
            this.label53.AutoSize = (true);
            this.label53.ForeColor = (global::System.Drawing.Color.White);
            this.label53.Location = (new global::System.Drawing.Point(999, 445));
            this.label53.Name = ("label53");
            this.label53.Size = (new global::System.Drawing.Size(73, 15));
            this.label53.TabIndex = (162);
            this.label53.Text = ("VCF - Cutoff");
            // 
            // ledEnv4
            // 
            this.ledEnv4.Clickable = (true);
            this.ledEnv4.ID = ("ENV4");
            this.ledEnv4.LedColor = (global::System.Drawing.Color.Red);
            this.ledEnv4.LedShape = (global::UI.Controls.Led.Shape.Square);
            this.ledEnv4.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledEnv4.Location = (new global::System.Drawing.Point(535, 456));
            this.ledEnv4.Name = ("ledEnv4");
            this.ledEnv4.Size = (new global::System.Drawing.Size(15, 10));
            this.ledEnv4.TabIndex = (168);
            this.ledEnv4.ToolTip = (null);
            // 
            // kEnv4Release
            // 
            this.kEnv4Release._v = (0D);
            this.kEnv4Release.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv4Release.BackgroundImage")));
            this.kEnv4Release.Default = (0D);
            this.kEnv4Release.Description = ("Envelope 3 - Release");
            this.kEnv4Release.Divisions = (10);
            this.kEnv4Release.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv4Release.HideLabels = (false);
            this.kEnv4Release.HideOutine = (true);
            this.kEnv4Release.HideTicks = (true);
            this.kEnv4Release.LabelMarker0 = ("0");
            this.kEnv4Release.LabelMarker10 = ("10");
            this.kEnv4Release.LabelMarker5 = ("");
            this.kEnv4Release.LabelText = ("RELEASE");
            this.kEnv4Release.LimitToInteger = (false);
            this.kEnv4Release.Location = (new global::System.Drawing.Point(755, 462));
            this.kEnv4Release.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv4Release.Max = (5D);
            this.kEnv4Release.Min = (0D);
            this.kEnv4Release.Name = ("kEnv4Release");
            this.kEnv4Release.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv4Release.SweepAngle = (270);
            this.kEnv4Release.TabIndex = (167);
            this.kEnv4Release.Thickness = (2);
            this.kEnv4Release.Value = (0D);
            // 
            // kEnv4Sustain
            // 
            this.kEnv4Sustain._v = (0D);
            this.kEnv4Sustain.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv4Sustain.BackgroundImage")));
            this.kEnv4Sustain.Default = (0D);
            this.kEnv4Sustain.Description = ("Envelope 3 - Sustain");
            this.kEnv4Sustain.Divisions = (10);
            this.kEnv4Sustain.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv4Sustain.HideLabels = (false);
            this.kEnv4Sustain.HideOutine = (true);
            this.kEnv4Sustain.HideTicks = (true);
            this.kEnv4Sustain.LabelMarker0 = ("0");
            this.kEnv4Sustain.LabelMarker10 = ("10");
            this.kEnv4Sustain.LabelMarker5 = ("");
            this.kEnv4Sustain.LabelText = ("SUSTAIN");
            this.kEnv4Sustain.LimitToInteger = (false);
            this.kEnv4Sustain.Location = (new global::System.Drawing.Point(681, 462));
            this.kEnv4Sustain.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv4Sustain.Max = (1D);
            this.kEnv4Sustain.Min = (0D);
            this.kEnv4Sustain.Name = ("kEnv4Sustain");
            this.kEnv4Sustain.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv4Sustain.SweepAngle = (270);
            this.kEnv4Sustain.TabIndex = (166);
            this.kEnv4Sustain.Thickness = (2);
            this.kEnv4Sustain.Value = (0D);
            // 
            // kEnv4Decay
            // 
            this.kEnv4Decay._v = (0D);
            this.kEnv4Decay.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv4Decay.BackgroundImage")));
            this.kEnv4Decay.Default = (0D);
            this.kEnv4Decay.Description = ("Envelope 3 - Decay");
            this.kEnv4Decay.Divisions = (10);
            this.kEnv4Decay.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv4Decay.HideLabels = (false);
            this.kEnv4Decay.HideOutine = (true);
            this.kEnv4Decay.HideTicks = (true);
            this.kEnv4Decay.LabelMarker0 = ("0");
            this.kEnv4Decay.LabelMarker10 = ("10");
            this.kEnv4Decay.LabelMarker5 = ("");
            this.kEnv4Decay.LabelText = ("DECAY");
            this.kEnv4Decay.LimitToInteger = (false);
            this.kEnv4Decay.Location = (new global::System.Drawing.Point(607, 462));
            this.kEnv4Decay.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv4Decay.Max = (5D);
            this.kEnv4Decay.Min = (0D);
            this.kEnv4Decay.Name = ("kEnv4Decay");
            this.kEnv4Decay.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv4Decay.SweepAngle = (270);
            this.kEnv4Decay.TabIndex = (165);
            this.kEnv4Decay.Thickness = (2);
            this.kEnv4Decay.Value = (0D);
            // 
            // kEnv4Attack
            // 
            this.kEnv4Attack._v = (0D);
            this.kEnv4Attack.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject("kEnv4Attack.BackgroundImage")));
            this.kEnv4Attack.Default = (0D);
            this.kEnv4Attack.Description = ("Envelope 3 - Attack");
            this.kEnv4Attack.Divisions = (10);
            this.kEnv4Attack.ForeColor = (global::System.Drawing.Color.White);
            this.kEnv4Attack.HideLabels = (false);
            this.kEnv4Attack.HideOutine = (true);
            this.kEnv4Attack.HideTicks = (true);
            this.kEnv4Attack.LabelMarker0 = ("0");
            this.kEnv4Attack.LabelMarker10 = ("10");
            this.kEnv4Attack.LabelMarker5 = ("");
            this.kEnv4Attack.LabelText = ("ATTACK");
            this.kEnv4Attack.LimitToInteger = (false);
            this.kEnv4Attack.Location = (new global::System.Drawing.Point(533, 462));
            this.kEnv4Attack.MarkerStyle = (global::UI.Controls.Knob.MarkerStyleEnum.Line);
            this.kEnv4Attack.Max = (5D);
            this.kEnv4Attack.Min = (0D);
            this.kEnv4Attack.Name = ("kEnv4Attack");
            this.kEnv4Attack.Size = (new global::System.Drawing.Size(77, 77));
            this.kEnv4Attack.SweepAngle = (270);
            this.kEnv4Attack.TabIndex = (164);
            this.kEnv4Attack.Thickness = (2);
            this.kEnv4Attack.Value = (0D);
            // 
            // panel12
            // 
            this.panel12.CornerRadius = (10);
            this.panel12.ID = ("");
            this.panel12.LabelText = ("ENV 4 - to patchbay");
            this.panel12.LineWidth = (2);
            this.panel12.Location = (new global::System.Drawing.Point(529, 444));
            this.panel12.Name = ("panel12");
            this.panel12.Selected = (false);
            this.panel12.Size = (new global::System.Drawing.Size(307, 105));
            this.panel12.TabIndex = (163);
            // 
            // label54
            // 
            this.label54.AutoSize = (true);
            this.label54.ForeColor = (global::System.Drawing.Color.White);
            this.label54.Location = (new global::System.Drawing.Point(870, 397));
            this.label54.Name = ("label54");
            this.label54.Size = (new global::System.Drawing.Size(40, 15));
            this.label54.TabIndex = (170);
            this.label54.Text = ("ENV4-");
            // 
            // label55
            // 
            this.label55.AutoSize = (true);
            this.label55.ForeColor = (global::System.Drawing.Color.White);
            this.label55.Location = (new global::System.Drawing.Point(870, 381));
            this.label55.Name = ("label55");
            this.label55.Size = (new global::System.Drawing.Size(43, 15));
            this.label55.TabIndex = (169);
            this.label55.Text = ("ENV4+");
            // 
            // label56
            // 
            this.label56.AutoSize = (true);
            this.label56.ForeColor = (global::System.Drawing.Color.White);
            this.label56.Location = (new global::System.Drawing.Point(870, 457));
            this.label56.Name = ("label56");
            this.label56.Size = (new global::System.Drawing.Size(50, 15));
            this.label56.TabIndex = (174);
            this.label56.Text = ("VCA5 - l");
            // 
            // label57
            // 
            this.label57.AutoSize = (true);
            this.label57.ForeColor = (global::System.Drawing.Color.White);
            this.label57.Location = (new global::System.Drawing.Point(870, 441));
            this.label57.Name = ("label57");
            this.label57.Size = (new global::System.Drawing.Size(54, 15));
            this.label57.TabIndex = (173);
            this.label57.Text = ("VCA4 - g");
            // 
            // label58
            // 
            this.label58.AutoSize = (true);
            this.label58.ForeColor = (global::System.Drawing.Color.White);
            this.label58.Location = (new global::System.Drawing.Point(870, 426));
            this.label58.Name = ("label58");
            this.label58.Size = (new global::System.Drawing.Size(51, 15));
            this.label58.TabIndex = (172);
            this.label58.Text = ("VCA3 - f");
            // 
            // label59
            // 
            this.label59.AutoSize = (true);
            this.label59.ForeColor = (global::System.Drawing.Color.White);
            this.label59.Location = (new global::System.Drawing.Point(870, 411));
            this.label59.Name = ("label59");
            this.label59.Size = (new global::System.Drawing.Size(53, 15));
            this.label59.TabIndex = (171);
            this.label59.Text = ("VCA2 - c");
            // 
            // ledGate2
            // 
            this.ledGate2.Clickable = (false);
            this.ledGate2.ID = ("");
            this.ledGate2.LedColor = (global::System.Drawing.Color.Lime);
            this.ledGate2.LedShape = (global::UI.Controls.Led.Shape.Round);
            this.ledGate2.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledGate2.Location = (new global::System.Drawing.Point(451, 397));
            this.ledGate2.Name = ("ledGate2");
            this.ledGate2.Size = (new global::System.Drawing.Size(15, 15));
            this.ledGate2.TabIndex = (175);
            this.ledGate2.ToolTip = (null);
            // 
            // ledGate3
            // 
            this.ledGate3.Clickable = (false);
            this.ledGate3.ID = ("");
            this.ledGate3.LedColor = (global::System.Drawing.Color.Lime);
            this.ledGate3.LedShape = (global::UI.Controls.Led.Shape.Round);
            this.ledGate3.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledGate3.Location = (new global::System.Drawing.Point(468, 397));
            this.ledGate3.Name = ("ledGate3");
            this.ledGate3.Size = (new global::System.Drawing.Size(15, 15));
            this.ledGate3.TabIndex = (176);
            this.ledGate3.ToolTip = (null);
            // 
            // ledGate4
            // 
            this.ledGate4.Clickable = (false);
            this.ledGate4.ID = ("");
            this.ledGate4.LedColor = (global::System.Drawing.Color.Lime);
            this.ledGate4.LedShape = (global::UI.Controls.Led.Shape.Round);
            this.ledGate4.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledGate4.Location = (new global::System.Drawing.Point(486, 397));
            this.ledGate4.Name = ("ledGate4");
            this.ledGate4.Size = (new global::System.Drawing.Size(15, 15));
            this.ledGate4.TabIndex = (177);
            this.ledGate4.ToolTip = (null);
            // 
            // ledGate5
            // 
            this.ledGate5.Clickable = (false);
            this.ledGate5.ID = ("");
            this.ledGate5.LedColor = (global::System.Drawing.Color.Lime);
            this.ledGate5.LedShape = (global::UI.Controls.Led.Shape.Round);
            this.ledGate5.LedState = (global::UI.Controls.Led.Enums.LedState.Off);
            this.ledGate5.Location = (new global::System.Drawing.Point(504, 397));
            this.ledGate5.Name = ("ledGate5");
            this.ledGate5.Size = (new global::System.Drawing.Size(15, 15));
            this.ledGate5.TabIndex = (178);
            this.ledGate5.ToolTip = (null);
            // 
            // frmMidiController
            // 
            this.AutoScaleDimensions = (new global::System.Drawing.SizeF(7F, 15F));
            this.AutoScaleMode = (global::System.Windows.Forms.AutoScaleMode.Font);
            this.BackColor = (global::System.Drawing.Color.Navy);
            this.ClientSize = (new global::System.Drawing.Size(1175, 558));
            this.Controls.Add(this.ledGate5);
            this.Controls.Add(this.ledGate4);
            this.Controls.Add(this.ledGate3);
            this.Controls.Add(this.ledGate2);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.ledEnv4);
            this.Controls.Add(this.kEnv4Release);
            this.Controls.Add(this.kEnv4Sustain);
            this.Controls.Add(this.kEnv4Decay);
            this.Controls.Add(this.kEnv4Attack);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ledVcas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.rect13);
            this.Controls.Add(this.rect14);
            this.Controls.Add(this.rect15);
            this.Controls.Add(this.rect16);
            this.Controls.Add(this.triangle4);
            this.Controls.Add(this.kVca5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rect12);
            this.Controls.Add(this.rect11);
            this.Controls.Add(this.rect10);
            this.Controls.Add(this.rect9);
            this.Controls.Add(this.rect8);
            this.Controls.Add(this.rect7);
            this.Controls.Add(this.rect6);
            this.Controls.Add(this.rect5);
            this.Controls.Add(this.rect4);
            this.Controls.Add(this.rect3);
            this.Controls.Add(this.rect2);
            this.Controls.Add(this.rect1);
            this.Controls.Add(this.triangle3);
            this.Controls.Add(this.kVca4);
            this.Controls.Add(this.triangle2);
            this.Controls.Add(this.kVca3);
            this.Controls.Add(this.triangle1);
            this.Controls.Add(this.kVca2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ledEffects);
            this.Controls.Add(this.ledEnv3);
            this.Controls.Add(this.ledEnv2);
            this.Controls.Add(this.ledBitCrush);
            this.Controls.Add(this.ledEnv1);
            this.Controls.Add(this.ledVCF);
            this.Controls.Add(this.ledMixer);
            this.Controls.Add(this.ledLFO);
            this.Controls.Add(this.ledVCO3);
            this.Controls.Add(this.ledVCO2);
            this.Controls.Add(this.ledVCO1);
            this.Controls.Add(this.kBitCrushResolution);
            this.Controls.Add(this.kBitCrushSampleRate);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.lblEffectType);
            this.Controls.Add(this.kEffectMix);
            this.Controls.Add(this.kEffectParam2);
            this.Controls.Add(this.kEffectParam1);
            this.Controls.Add(this.kEffectType);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.cmdControllers);
            this.Controls.Add(this.ledLfo2);
            this.Controls.Add(this.ledLfo1);
            this.Controls.Add(this.ledGate1);
            this.Controls.Add(this.cboMidiChannel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMidiChannel);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.cmdViewWave);
            this.Controls.Add(this.lblFilterType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kEnv3Release);
            this.Controls.Add(this.kEnv3Sustain);
            this.Controls.Add(this.kEnv3Decay);
            this.Controls.Add(this.kEnv3Attack);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.kLfo2Shape);
            this.Controls.Add(this.kLfo2Rate);
            this.Controls.Add(this.kLfo1Shape);
            this.Controls.Add(this.kLfo1Rate);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.kNoiseMix);
            this.Controls.Add(this.kGlide);
            this.Controls.Add(this.kEnv2Release);
            this.Controls.Add(this.kEnv2Sustain);
            this.Controls.Add(this.kEnv2Decay);
            this.Controls.Add(this.kEnv2Attack);
            this.Controls.Add(this.kEnv1Release);
            this.Controls.Add(this.kEnv1Sustain);
            this.Controls.Add(this.kEnv1Decay);
            this.Controls.Add(this.kEnv1Attack);
            this.Controls.Add(this.kVcfEnvelope);
            this.Controls.Add(this.kVcfResonance);
            this.Controls.Add(this.kVcfCutoff);
            this.Controls.Add(this.kVcfType);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.kOsc3Mix);
            this.Controls.Add(this.kOsc2Mix);
            this.Controls.Add(this.kOsc1Mix);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.kVco3Waveform);
            this.Controls.Add(this.kVco3PW);
            this.Controls.Add(this.kVco3Octave);
            this.Controls.Add(this.kVco3Freq);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.kVco2Waveform);
            this.Controls.Add(this.kVco2PW);
            this.Controls.Add(this.kVco2Octave);
            this.Controls.Add(this.kVco2Freq);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.kVco1Waveform);
            this.Controls.Add(this.kVco1PW);
            this.Controls.Add(this.kVco1Octave);
            this.Controls.Add(this.kVco1Freq);
            this.Controls.Add(this.panel1);
            this.Name = ("frmMidiController");
            this.Text = ("Shed Prophet");
            ((global::System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Controls.Panel panel1;
        private Controls.Knob kVco1Freq;
        private Controls.Knob kVco1Octave;
        private Controls.Knob kVco1PW;
        private Controls.Knob kVco1Waveform;
        private Controls.Knob kVco2Waveform;
        private Controls.Knob kVco2PW;
        private Controls.Knob kVco2Octave;
        private Controls.Knob kVco2Freq;
        private Controls.Panel panel2;
        private Controls.Knob kVco3Waveform;
        private Controls.Knob kVco3PW;
        private Controls.Knob kVco3Octave;
        private Controls.Knob kVco3Freq;
        private Controls.Panel panel3;
        private Controls.Panel panel4;
        private Controls.Knob kOsc1Mix;
        private Controls.Knob kOsc2Mix;
        private Controls.Knob kOsc3Mix;
        private Controls.Panel panel5;
        private Controls.Panel panel6;
        private Controls.Knob kVcfType;
        private Controls.Knob kVcfCutoff;
        private Controls.Knob kVcfResonance;
        private Controls.Knob kVcfEnvelope;
        private Controls.Knob kEnv1Release;
        private Controls.Knob kEnv1Sustain;
        private Controls.Knob kEnv1Decay;
        private Controls.Knob kEnv1Attack;
        private Controls.Knob kEnv2Release;
        private Controls.Knob kEnv2Sustain;
        private Controls.Knob kEnv2Decay;
        private Controls.Knob kEnv2Attack;
        private Controls.Knob kGlide;
        private Controls.Knob kNoiseMix;
        private Controls.Panel panel7;
        private Controls.Knob kLfo1Shape;
        private Controls.Knob kLfo1Rate;
        private Controls.Knob kLfo2Shape;
        private Controls.Knob kLfo2Rate;
        private Controls.Knob kEnv3Release;
        private Controls.Knob kEnv3Sustain;
        private Controls.Knob kEnv3Decay;
        private Controls.Knob kEnv3Attack;
        private Controls.Panel panel9;
        private PictureBox pictureBox1;
        private Label lblFilterType;
        private Button cmdViewWave;
        private Button cmdInit;
        private Label lblMidiChannel;
        private Label label2;
        private ComboBox cboMidiChannel;
        private Controls.Led ledGate1;
        private Controls.Led ledLfo1;
        private Controls.Led ledLfo2;
        private Button cmdControllers;
        private Controls.Panel panel10;
        private Controls.Knob kEffectParam1;
        private Controls.Knob kEffectType;
        private Controls.Knob kEffectMix;
        private Controls.Knob kEffectParam2;
        private Label lblEffectType;
        private Controls.Panel panel11;
        private Controls.Knob kBitCrushSampleRate;
        private Controls.Knob kBitCrushResolution;
        private Label label1;
        private Label label3;
        private Controls.Led ledVCO1;
        private Controls.Led ledVCO2;
        private Controls.Led ledVCO3;
        private Controls.Led ledLFO;
        private Controls.Led ledMixer;
        private Controls.Led ledVCF;
        private Controls.Led ledEnv1;
        private Controls.Led ledBitCrush;
        private Controls.Led ledEnv2;
        private Controls.Led ledEnv3;
        private Controls.Led ledEffects;
        private Controls.Panel panel8;
        private Label label4;
        private Label label5;
        private Controls.Triangle triangle1;
        private Controls.Knob kVca2;
        private Controls.Triangle triangle2;
        private Controls.Knob kVca3;
        private Controls.Triangle triangle3;
        private Controls.Knob kVca4;
        private Controls.Rect rect1;
        private Controls.Rect rect2;
        private Controls.Rect rect3;
        private Controls.Rect rect4;
        private Controls.Rect rect5;
        private Controls.Rect rect6;
        private Controls.Rect rect7;
        private Controls.Rect rect8;
        private Controls.Rect rect9;
        private Controls.Rect rect10;
        private Controls.Rect rect11;
        private Controls.Rect rect12;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Controls.Rect rect13;
        private Controls.Rect rect14;
        private Controls.Rect rect15;
        private Controls.Rect rect16;
        private Controls.Triangle triangle4;
        private Controls.Knob kVca5;
        private Controls.Led ledVcas;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Controls.Led ledEnv4;
        private Controls.Knob kEnv4Release;
        private Controls.Knob kEnv4Sustain;
        private Controls.Knob kEnv4Decay;
        private Controls.Knob kEnv4Attack;
        private Controls.Panel panel12;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private global::UI.Controls.Led ledGate2;
        private global::UI.Controls.Led ledGate3;
        private global::UI.Controls.Led ledGate4;
        private global::UI.Controls.Led ledGate5;
    }
}