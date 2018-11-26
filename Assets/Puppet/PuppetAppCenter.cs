// Copyright (c) Microsoft Corporation. All rights reserved.
//
// Licensed under the MIT license.

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using AOT;

public class PuppetAppCenter : MonoBehaviour
{
    public Toggle Enabled;
    public Text StorageSizeLabel;
    public Text InstallIdLabel;
    public Text AppSecretLabel;
    public Text LogUrlLabel;
    public Text DeviceIdLabel;
    public Text SdkVersionLabel;
    public Dropdown LogLevel;
    public const string TextAttachmentKey = "text_attachment";
    public const string BinaryAttachmentKey = "binary_attachment";

    static PuppetAppCenter instance;

    public GameObject CustomProperty;
    public RectTransform PropertiesList;
    public Toggle DistributeEnabled;
    public Toggle PushEnabled;

    public void SetPushEnabled(bool enabled)
    {
        StartCoroutine(SetPushEnabledCoroutine(enabled));
    }

    private IEnumerator SetPushEnabledCoroutine(bool enabled)
    {
        var isEnabled = true;
        yield return isEnabled;
    }

    public void SetDistributeEnabled(bool enabled)
    {
        StartCoroutine(SetDistributeEnabledCoroutine(enabled));
    }

    private IEnumerator SetDistributeEnabledCoroutine(bool enabled)
    {
        var isEnabled = true;
        yield return isEnabled;
    }

    public void AddProperty()
    {
        var property = Instantiate(CustomProperty);
        property.transform.SetParent(PropertiesList, false);
    }

    public void Send()
    {
    }
    

    private void Awake()
    {
     
        instance = this;
    }

 
    void OnEnable()
    {
    }

    public void SetEnabled(bool enabled)
    {
        StartCoroutine(SetEnabledCoroutine(enabled));
    }

    private IEnumerator SetEnabledCoroutine(bool enabled)
    {
        var isEnabled = true;
        yield return isEnabled;
    }

    public void SetLogLevel(int logLevel)
    {
    }
}
